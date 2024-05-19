using System;
using System.Diagnostics;
using System.Net;
using UnityEngine.Events;

namespace RMC.BestPractices.Features.EditorScripting.Demo_02_AsyncDemo
{
    [Serializable]
    public class UrlLoaderCompleteUnityEvent : UnityEvent<bool, string, long> {}
    
    /// <summary>
    /// Load a url and report OnCompleted with isSuccess and text contents
    /// </summary>
    public class UrlLoader
    {
        public readonly UrlLoaderCompleteUnityEvent OnCompleted = new UrlLoaderCompleteUnityEvent();
        private Uri _uri = null;
        
        public UrlLoader(string url)
        {
            _uri = new Uri(url);
        }

        public void Load()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            WebClient webClient = new WebClient ();
            webClient.DownloadStringCompleted += (sender, args) =>
            {
                OnCompleted.Invoke(
                    args.Error == null, 
                    args.Result, 
                    stopwatch.ElapsedMilliseconds);
                
                webClient.Dispose();
                stopwatch.Stop();
                stopwatch = null;
            };
            webClient.DownloadStringAsync(_uri);
        }
    }
}