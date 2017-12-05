using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

namespace Cultivation.Level
{

    public class TopCultivationLevel : CultivationLevel
    {
        public static CultivationLevel INSTANCE = new TopCultivationLevel();

        public override List<BrakethroughRequirenment> getBreakthroughRequirementList()
        {
            return new List<BrakethroughRequirenment>();
        }

        public override string getDescription()
        {
            return "You have riched the top level of cultivation!";
        }

        public override string getName()
        {
            return "Top Cultivator";
        }

        public override CultivationLevel nextLevelOfCultivation()
        {
            return INSTANCE;
        }
    }

}