using UnityEngine;
using System.Collections;
using Meditation.Technique;
using Meditation.Result;
using Cultivation;
using Cultivation.State;

namespace Services
{

    public class MeditationService : MonoBehaviour
    {

        public void Meditate(Character character, MeditationTechnique technique)
        {

            Meditate(character, technique, 1);
        }

        //TODO think of time period (date) instead of hours
        public void Meditate(Character character, MeditationTechnique technique, int hours)
        {
            MeditationResult result = technique.GetMeditationResult();
            CultivationBody body = character.EnergyBody; //TODO think of abstracting techniques to make changes with Cultivation Body instead of Character
            body.State.CurrentState += result.EnergyChange;
            //TODO think of moving this logic into CultivationState class or its subclass
            if (body.State.CurrentState > body.State.CultivationProgress)
            {
                body.State.CultivationProgress = body.State.CurrentState;
            }
        }
    }

}