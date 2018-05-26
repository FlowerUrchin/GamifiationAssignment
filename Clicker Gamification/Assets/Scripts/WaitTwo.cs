using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Pressed()
    {
        GameManager.instance.SpendGold(-100);
    }
}
