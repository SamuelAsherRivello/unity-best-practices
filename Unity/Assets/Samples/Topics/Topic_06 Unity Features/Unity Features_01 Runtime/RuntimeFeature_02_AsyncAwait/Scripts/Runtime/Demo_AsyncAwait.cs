using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using RMC.BestPractices.Shared;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

namespace RMC.BestPractices.Features.EditorScripting.Demo_02_AsyncDemo
{
	/// <summary>
	/// Demonstrates 3 approaches to running a series of operations.
	/// </summary>
	public class Demo_AsyncAwait : BaseDemo
	{
		[Header("Demo")]
		[SerializeField]
		private Button _syncSerialButton = null;
		
		[SerializeField]
		private Button _asyncSerialButton = null;

		[SerializeField]
		private Button _syncParallelButton = null;

		private List<string> urls = new List<string>();
		
		protected override void Start()
		{
			// Must call base
			base.Start();

			_syncSerialButton.onClick.AddListener(OnSyncSerialButtonClicked);
			_asyncSerialButton.onClick.AddListener(OnAsyncSerialButtonClicked);
			_syncParallelButton.onClick.AddListener(OnAsyncParallelButtonClicked);
			
			urls.Add("https://www.Wikipedia.com");
			urls.Add("https://www.Google.com");
			urls.Add("https://www.Bing.com");
			urls.Add("https://www.Yahoo.com");
			urls.Add("https://duckduckgo.com/");
		}

		/// <summary>
		/// Do the operations without waiting
		/// </summary>
		private void LoadSerialSync()
		{
			int count = 0;
			foreach (var url in urls)
			{
				UrlLoader urlLoader = new UrlLoader(url);
				
				urlLoader.OnCompleted.AddListener((isSuccess, text, elapsedTime) =>
				{
					LogResults(url, count++, text, elapsedTime);
				});
				
				urlLoader.Load();
			}
		}
		
		/// <summary>
		/// Do the operations and each waits for previous
		/// </summary>
		private async Task LoadSerialAsync()
		{
			int count = 0;

			foreach (var url in urls)
			{
				// Wait for ONE to be complete
				await Task.Run(() => LoadUrlLoaderTask(url, ++count));
			}
		}
		
		/// <summary>
		/// Do the operations and and wait for the complete set to be finished
		/// </summary>
		private async Task LoadParallelAsync()
		{
			int count = 0;

			List<Task> tasks = new List<Task>();

			foreach (var url in urls)
			{
				tasks.Add(Task.Run(() => LoadUrlLoaderTask(url, ++count)));
			}

			// Wait for ALL to be complete
			await Task.WhenAll(tasks);
		}

		private async Task<UrlLoader> LoadUrlLoaderTask(string url, int count)
		{
			UrlLoader urlLoader = new UrlLoader(url);

			bool isComplete = false;
			
			urlLoader.OnCompleted.AddListener((isSuccess, text, elapsedTime) =>
			{
				isComplete = true;
				LogResults(url, count, text, elapsedTime);
			});

			urlLoader.Load();

			while (!isComplete)
			{
				await Task.Delay(100);
			}

			return urlLoader;
		}

		private void LogResults(string url, int count, string text, long elapsedTime)
		{
			Debug.LogFormat("{0}={1}, text.Length={2}, elapsedTime={3} ", count, url, text.Length, elapsedTime);
		}

		private void OnSyncSerialButtonClicked()
		{
			Debug.Log("1 LoadSerial()");
			Stopwatch stopwatch = Stopwatch.StartNew();
			
			LoadSerialSync();
			
			//This log occurs BEFORE the operations
			Debug.LogFormat("Elapsed: {0} milliseconds", stopwatch.ElapsedMilliseconds);
		}
		
		private async void OnAsyncSerialButtonClicked()
		{
			Debug.Log("2 LoadSerialAsync()");
			Stopwatch stopwatch = Stopwatch.StartNew();
			
			await LoadSerialAsync();
			
			//This log occurs AFTER the operations
			Debug.LogFormat("Elapsed: {0} milliseconds", stopwatch.ElapsedMilliseconds);
		}
		
		private async void OnAsyncParallelButtonClicked()
		{
			Debug.LogFormat("3 LoadParallelAsync()");
			Stopwatch stopwatch = Stopwatch.StartNew();
			
			await LoadParallelAsync();
			
			//This log occurs AFTER the operations
			Debug.LogFormat("Elapsed: {0} milliseconds", stopwatch.ElapsedMilliseconds);
		}
	}
}