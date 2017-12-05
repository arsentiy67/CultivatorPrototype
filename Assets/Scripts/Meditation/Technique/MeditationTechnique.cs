using UnityEngine;
using System.Collections;
using Cultivation.Level;
using Meditation.Result;

namespace Meditation.Technique
{
    public abstract class MeditationTechnique
    {
        public abstract string GetName();

        public abstract string GetDescription();

        //TODO think of reterning an object
        public abstract bool Applicable(CultivationLevel cultivationLevel);

        //TODO think of return type and input parameters
        public abstract MeditationResult GetMeditationResult();
    }
}