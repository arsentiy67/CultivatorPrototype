using UnityEngine;
using System.Collections;

public class GameWorld : MonoBehaviour {

    private Character player;

	// Use this for initialization
	void Start () {
        player = new Character();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Character GetPlayer()
    {
        return player;
    }
}
