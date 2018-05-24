using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinChange : MonoBehaviour {

    int value = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Pressed()
    {
        GameManager.instance.SpendGold(-value);
        GameManager.instance.GrabCoin();
        gameObject.SetActive(false);
    }
    public void SetValue(int amount)
    {
        gameObject.SetActive(true);
        value = amount;
    }
}
