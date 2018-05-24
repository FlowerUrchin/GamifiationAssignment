using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceUpgradeButton : MonoBehaviour {

    public GameObject costText, showLevel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Pressed()
    {
        if (costText.GetComponent<UpgradeIce>().Upgrade())
        {
            showLevel.GetComponent<IceMageLevel>().Upgrade();
        }
    }
}
