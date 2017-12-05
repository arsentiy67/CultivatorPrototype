using UnityEngine;
using System.Collections;
using System;
using Cultivation.Level;
using Meditation.Result;

namespace Meditation.Technique
{
    public class BasicMeditationTechnique : MeditationTechnique
    {
        public override bool Applicable(CultivationLevel cultivationLevel)
        {
            return cultivationLevel is BasicCultivationLevel;
        }

        public override string GetDescription()
        {
            return "Just basic technique for meditaton";
        }

        public override MeditationResult GetMeditationResult()
        {
            return new MeditationResult(1);
        }

        public override string GetName()
        {
            return "Basic Mantra";
        }
    }
}