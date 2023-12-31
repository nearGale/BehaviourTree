﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public enum BTreeStatus
    {
        Invalid,
        Success,
        Failure,
        Running,
    }

    public abstract class BTreeBehavior
    {
        protected virtual void OnInitialize() { }
        protected abstract BTreeStatus Update();
        protected virtual void OnTerminate(BTreeStatus status) { }

        public BTreeStatus Status { get { return m_Status; } }
        private BTreeStatus m_Status;

        public BTreeBehavior()
        {
            m_Status = BTreeStatus.Invalid;
        }

        ~BTreeBehavior()
        {

        }

        public BTreeStatus Tick()
        {
            if (IsTerminated())
                OnInitialize();

            m_Status = Update();

            if (IsTerminated())
                OnTerminate(m_Status);

            return m_Status;
        }

        public bool IsTerminated()
        {
            return m_Status == BTreeStatus.Success || m_Status == BTreeStatus.Failure || m_Status == BTreeStatus.Invalid;
        }

        public virtual void Abort()
        {
            OnTerminate(BTreeStatus.Failure);
        }
    }
}
