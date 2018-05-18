using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCost : MonoBehaviour {

    Text upgradeFire;
    int cost = 50;

	// Use this for initialization
	void Start ()
    {
        upgradeFire = GetComponent<Text>();

		
	}
	
	// Update is called once per frame
	void Update ()
    {
        upgradeFire.text = "Cost to upgrade: " + cost;
	}
    public bool Upgrade()
    {
        if((GameManager.instance.gold - cost) >= 0)
        {
            GameManager.instance.SpendGold(cost);
            cost += 50;//Increase cost
            return true;
        }
        else
        {
            return false;
        }
    }
}
