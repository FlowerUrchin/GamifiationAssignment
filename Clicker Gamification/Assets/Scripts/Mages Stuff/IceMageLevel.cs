using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IceMageLevel : MonoBehaviour {

    static int trueLevel = 1;
    int level = trueLevel;
    Text showLevel;

    // Use this for initialization
    void Start()
    {
        trueLevel = GameManager.instance.GetIce();
        showLevel = GetComponent<Text>();
        showLevel.text = "Ice Mage Level: " + level;
    }

    // Update is called once per frame
    void Update()
    {
        trueLevel = GameManager.instance.GetIce();
        level = trueLevel;
        showLevel.text = "Ice Mage Level: " + level;
    }
    public void Upgrade()
    {
        GameManager.instance.Ice();
    }
}
