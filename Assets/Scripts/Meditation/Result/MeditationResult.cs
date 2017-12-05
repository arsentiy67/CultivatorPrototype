using UnityEngine;
using System.Collections;

namespace Meditation.Result
{
    public class MeditationResult
    {

        private int _energyChange;

        public int EnergyChange
        {
            get
            {
                return _energyChange;
            }
        }

        public MeditationResult(int energyChange)
        {
            this._energyChange = energyChange;
        }
    }
}