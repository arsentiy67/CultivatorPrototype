using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Cultivation.Level
{

    public abstract class CultivationLevel
    {
        public abstract string getName();

        public abstract string getDescription();

        public abstract List<BrakethroughRequirenment> getBreakthroughRequirementList();

        public abstract CultivationLevel nextLevelOfCultivation();
    }

}