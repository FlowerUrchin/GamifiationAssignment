using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireMageLevel : MonoBehaviour {

    static int trueLevel = 1;
    int level = trueLevel;
    Text showLevel;

	// Use this for initialization
	void Start ()
    {
        trueLevel = GameManager.instance.GetFire();
        showLevel = GetComponent<Text>();
        showLevel.text = "Fire Mage Level: " + level;		
	}
	
	// Update is called once per frame
	void Update ()
    {
        trueLevel = GameManager.instance.GetFire();
        level = trueLevel;
        showLevel.text = "Fire Mage Level: " + level;
    }
    public void Upgrade()
    {
        GameManager.instance.Fire();
    }
}
