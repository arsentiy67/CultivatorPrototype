using UnityEngine;
using System.Collections;
using Services;
using Meditation.Technique;
using UnityEngine.UI;

public class UIHandlers : MonoBehaviour {

    private GameWorld gameWorld;
    private MeditationService meditationService;
    [SerializeField]
    private Text textMeditationInfo = null;

    // Use this for initialization
    void Start () {
        GameObject gameWorldObj = GameObject.Find("Camera");
        gameWorld = gameWorldObj.GetComponent(typeof(GameWorld)) as GameWorld;
        meditationService = gameWorldObj.GetComponent(typeof(MeditationService)) as MeditationService;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Meditate()
    {
        Character player = gameWorld.GetPlayer();
        meditationService.Meditate(player, new BasicMeditationTechnique());

        UpdateUIInfo();
    }

    public void UpdateUIInfo()
    {
        Character player = gameWorld.GetPlayer();
        textMeditationInfo.text = player.EnergyBody.State.ToString();
    }
}
