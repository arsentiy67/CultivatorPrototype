using UnityEngine;
using System.Collections;
using Cultivation.Level;
using Cultivation.State;

namespace Cultivation
{
    public class CultivationBody
    {
        //TODO add features (temporary/ semi-permanent (permanent unil not time based condition)) as features of the body (or maybe Character)

        public CultivationBody(CultivationState state, CultivationLevel level)
        {
            State = state;
            Level = level;
        }

        private CultivationState _state;
        private CultivationLevel _level;

        public CultivationState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public CultivationLevel Level
        {
            get { return _level; }
            set { _level = value; }
        }

    }
}