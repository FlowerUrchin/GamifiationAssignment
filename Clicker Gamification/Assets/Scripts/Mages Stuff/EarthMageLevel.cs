using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthMageLevel : MonoBehaviour {

    static int trueLevel = 1;
    int level = trueLevel;
    Text showLevel;

    // Use this for initialization
    void Start()
    {
        trueLevel = GameManager.instance.GetEarth();
        showLevel = GetComponent<Text>();
        showLevel.text = "Earth Mage Level: " + level;
    }

    // Update is called once per frame
    void Update()
    {
        trueLevel = GameManager.instance.GetEarth();
        level = trueLevel;
        showLevel.text = "Earth Mage Level: " + level;
    }
    public void Upgrade()
    {
        GameManager.instance.Earth();
    }
}
