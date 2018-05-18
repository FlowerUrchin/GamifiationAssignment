using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldLevel : MonoBehaviour {

    Text goldScore;

	// Use this for initialization
	void Start () {
        goldScore = GetComponent<Text>();
        goldScore.text = "Gold:" + GameManager.instance.Gold();
	}
	
	// Update is called once per frame
	void Update ()
    {
        goldScore.text = "Gold:" + GameManager.instance.Gold();
    }
}
