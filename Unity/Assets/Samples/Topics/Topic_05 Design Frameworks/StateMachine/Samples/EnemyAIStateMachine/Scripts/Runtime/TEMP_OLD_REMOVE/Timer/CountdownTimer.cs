using System;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public class CountdownTimer : Timer
    {
        public CountdownTimer(float value) : base(value) { }

        public override void Tick(float deltaTime) {
            if (IsRunning && Time > 0) {
                Time -= deltaTime;
            }
            
            if (IsRunning && Time <= 0) {
                Stop();
            }
        }
        
        public bool IsFinished => Time <= 0;
        
        public void Reset() => Time = initialTime;
        
        public void Reset(float newTime) {
            initialTime = newTime;
            Reset();
        }
    }
    
    public class StopwatchTimer : Timer {
        public StopwatchTimer() : base(0) { }

        public override void Tick(float deltaTime) {
            if (IsRunning) {
                Time += deltaTime;
            }
        }
        
        public void Reset() => Time = 0;
        
        public float GetTime() => Time;
    }
}