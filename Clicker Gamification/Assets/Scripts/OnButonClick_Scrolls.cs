using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnButonClick_Scrolls : MonoBehaviour {

    //Buttons
    public Button readingScroll, mathsScroll, back, newScroll;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //go to reading scroll
    public void OnClick_Reading() {
    
        SceneManager.LoadScene("Reading Scroll");
        
    }

    //go to maths scroll
    public void OnClick_Maths() {
    
        SceneManager.LoadScene("Calculus Scroll");
        
    }

    //go back to previous page
    public void OnClick_Back() { 
    
    }

    //go to scroll creation page
    public void OnClick_NewScroll() { 
        
    }
}
