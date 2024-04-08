﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public class ConditionFalse : Condition
    {
        public ConditionFalse(BehaviorTree tree, string name) : base(tree, name)
        {
        }

        protected override BTreeStatus OnUpdate()
        {
            Debug.Log("ConditionFalse");
            return BTreeStatus.Failure;
        }
    }
}
