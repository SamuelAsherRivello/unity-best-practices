﻿using UnityEngine;

namespace RMC.Core.Frameworks.StateMachineFramework 
{
    public abstract class BaseState : IState {
        protected readonly Player player;
        protected readonly Animator animator;
        
        protected static readonly int LocomotionHash = Animator.StringToHash("Locomotion");
        protected static readonly int JumpHash = Animator.StringToHash("Jump");
        protected static readonly int DashHash = Animator.StringToHash("Dash");
        protected static readonly int AttackHash = Animator.StringToHash("Attack");
        
        protected const float crossFadeDuration = 0.1f;
        
        protected BaseState(Player player, Animator animator) {
            this.player = player;
            this.animator = animator;
        }
        
        public virtual void OnEnter() {
            // noop
        }

        public virtual void Update() {
            // noop
        }

        public virtual void FixedUpdate() {
            // noop
        }

        public virtual void OnExit() {
            // noop
        }
    }
}