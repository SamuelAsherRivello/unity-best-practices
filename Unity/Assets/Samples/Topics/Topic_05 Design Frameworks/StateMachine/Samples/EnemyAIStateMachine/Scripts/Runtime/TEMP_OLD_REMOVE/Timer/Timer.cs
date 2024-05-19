using System;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public abstract class Timer 
    {
        protected float initialTime;
        protected float Time { get; set; }
        public bool IsRunning { get; protected set; }
        
        public float Progress => Time / initialTime;
        
        public Action OnTimerStart = delegate { };
        public Action OnTimerStop = delegate { };

        protected Timer(float value) {
            initialTime = value;
            IsRunning = false;
        }

        public void Start() {
            Time = initialTime;
            if (!IsRunning) {
                IsRunning = true;
                OnTimerStart.Invoke();
            }
        }

        public void Stop() {
            if (IsRunning) {
                IsRunning = false;
                OnTimerStop.Invoke();
            }
        }
        
        public void Resume() => IsRunning = true;
        public void Pause() => IsRunning = false;
        
        public abstract void Tick(float deltaTime);
    }
    
}