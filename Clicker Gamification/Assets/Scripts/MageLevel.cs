using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MageLevel : MonoBehaviour {

    int level = 1;
    Text showLevel;

	// Use this for initialization
	void Start ()
    {
        showLevel = GetComponent<Text>();
        showLevel.text = "Fire Mage Level: " + level;		
	}
	
	// Update is called once per frame
	void Update ()
    {
        showLevel.text = "Fire Mage Level: " + level;
    }
    public void Upgrade()
    {
        level++;
    }
}
