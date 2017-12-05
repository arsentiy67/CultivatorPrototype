using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Cultivation.Level;
using Cultivation.State;
using Cultivation;
using Meditation.Technique;

public class Character {

    private List<MeditationTechnique> _meditationTechniques = new List<MeditationTechnique>();
    private CultivationBody _physicalBody = new CultivationBody(new CultivationState(10, 10, 100), new BasicCultivationLevel());
    private CultivationBody _energyBody = new CultivationBody(new CultivationState(0, 0, 100), new BasicCultivationLevel());

    public List<MeditationTechnique> MeditationTechniques //TODO move to inventory/knowledge like thing
    {
        get { return _meditationTechniques; }
    }

    public CultivationBody PhysicalBody
    {
        get { return _physicalBody; }
        set { _physicalBody = value; }
    }

    public CultivationBody EnergyBody
    {
        get { return _energyBody; }
        set { _energyBody = value; }
    }

}
