using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeIce : MonoBehaviour {

    Text upgradeIce;
    static int cost = 50;

    // Use this for initialization
    void Start()
    {
        upgradeIce = GetComponent<Text>();
        //gets current cost

    }

    // Update is called once per frame
    void Update()
    {
        upgradeIce.text = "Cost to upgrade: " + cost;
    }
    public bool Upgrade()
    {
        if ((GameManager.instance.gold - cost) >= 0)
        {
            GameManager.instance.SpendGold(cost);
            cost += 100;//Increase cost
            return true;
        }
        else
        {
            return false;
        }
    }
}
