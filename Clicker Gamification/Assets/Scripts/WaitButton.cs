using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitButton : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void Pressed()
    {
        GameManager.instance.SpendGold(-100);
        SceneManager.LoadScene("Main Menu");
    }
}
