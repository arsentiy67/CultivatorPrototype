using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Cultivation.Level
{

    public class BasicCultivationLevel : CultivationLevel
    {
        public override List<BrakethroughRequirenment> getBreakthroughRequirementList()
        {
            return new List<BrakethroughRequirenment>();
        }

        public override string getDescription()
        {
            return "No cultivation yet";
        }

        public override string getName()
        {
            return "Basic Cultivation Level";
        }

        public override CultivationLevel nextLevelOfCultivation()
        {
            return TopCultivationLevel.INSTANCE;
        }
    }
}