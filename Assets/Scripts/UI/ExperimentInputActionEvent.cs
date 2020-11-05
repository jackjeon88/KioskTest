﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace KioskTest.UI
{
    [Serializable]
    public class ExperimentInputActionEvent : UnityEvent<GameObject, ExperimentInputActionEvent.EventArgs>
    {
        public struct EventArgs
        {
            public int[] Answers;
            public int AnswerCount { get { return Answers.Length; } }
        }
    }
}
