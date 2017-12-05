using UnityEngine;
using System.Collections;

namespace Cultivation.State
{
    public class CultivationState
    {
        private int _currentState; //body state (of any kind - physical/energy/soul etc) at the moment
        private int _cultivationProgress; //level reached, easy to restore Current State back to this base level
        private int _cultivationPeak; //reaching this level means closing the distance to breakthrough and also slowing down cultivation progress until the breakthrough

        public CultivationState(int currentState, int cultivationProgress, int cultivationPeak)
        {
            CurrentState = currentState;
            CultivationProgress = cultivationProgress;
            CultivationPeak = cultivationPeak;
        }

        public int CurrentState
        {
            get { return _currentState; }
            set { _currentState = value; }
        }

        public int CultivationProgress
        {
            get { return _cultivationProgress; }
            set { _cultivationProgress = value; }
        }

        public int CultivationPeak
        {
            get { return _cultivationPeak; }
            set { _cultivationPeak = value; }
        }

        public override string ToString()
        {
            return "Current state: " + _currentState + ", max reached progress: " + _cultivationProgress + ", peak: " + _cultivationPeak;
        }
    }
}