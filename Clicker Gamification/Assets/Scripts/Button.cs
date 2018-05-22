using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void hit()
    {
        GameManager.instance.foes[GameManager.instance.foe-1].GetComponent<TapFoe>().Tap();
    }
}
