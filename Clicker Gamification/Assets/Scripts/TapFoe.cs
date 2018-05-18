using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapFoe : MonoBehaviour
{
    int health = 50;
    public Slider enemyHealth;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        enemyHealth.value = health;
	}
    public void Tap()
    {
        health--;
    }
}
