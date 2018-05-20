using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnClick_Scrolls_Continue : MonoBehaviour {

    //Canvases
    public Canvas Reading, Q1, Q2, Q3, Q4;
    public List<Canvas> CanvasList;
    private int listno = 0;
	// Use this for initialization
	void Start () {
		CanvasList = new List<Canvas>{Reading, Q1, Q2, Q3, Q4};
	}
	
	// Update is called once per frame
	void Update () {
		//print(CanvasList[listno]);
        ChangeVisableCanvas();
	}

    //check if listno > 4 and jump back to scroll selection if so otherwise increment listno.
    public void OnClick_Continue() { 
        if (listno > 4) { 
        
            SceneManager.LoadScene("Scroll Screen");
        
        } else {
    
            listno += 1;
    
        }
         
    }

    //check if listno < 0 and jump back to scroll selection if so otherwise decrement listno.
    public void OnClick_Back() { 
        if (listno < 0) { 
        
            SceneManager.LoadScene("Scroll Screen");
        
        } else {
    
            listno -= 1;
    
        }
         
    }

    //changes which of the canvases is visable
    private void ChangeVisableCanvas() { 

        //if Reading is the active canvas
        if (listno == 0) {
    
            Reading.GetComponent<Canvas>().enabled = true;
            Q1.GetComponent<Canvas>().enabled = false;
            Q2.GetComponent<Canvas>().enabled = false;
            Q3.GetComponent<Canvas>().enabled = false;
            Q4.GetComponent<Canvas>().enabled = false;
    
        }

        //if Q1 is the active canvas
        if (listno == 1) {
    
            Reading.GetComponent<Canvas>().enabled = false;
            Q1.GetComponent<Canvas>().enabled = true;
            Q2.GetComponent<Canvas>().enabled = false;
            Q3.GetComponent<Canvas>().enabled = false;
            Q4.GetComponent<Canvas>().enabled = false;
    
        }

        //if Q2 is the active canvas
        if (listno == 2) {
    
            Reading.GetComponent<Canvas>().enabled = false;
            Q1.GetComponent<Canvas>().enabled = false;
            Q2.GetComponent<Canvas>().enabled = true;
            Q3.GetComponent<Canvas>().enabled = false;
            Q4.GetComponent<Canvas>().enabled = false;
    
        }

        //if Q3 is the active canvas
        if (listno == 3) {
    
            Reading.GetComponent<Canvas>().enabled = false;
            Q1.GetComponent<Canvas>().enabled = false;
            Q2.GetComponent<Canvas>().enabled = false;
            Q3.GetComponent<Canvas>().enabled = true;
            Q4.GetComponent<Canvas>().enabled = false;
    
        }

        //if Q4 is the active canvas
        if (listno >= 4) {
    
            Reading.GetComponent<Canvas>().enabled = false;
            Q1.GetComponent<Canvas>().enabled = false;
            Q2.GetComponent<Canvas>().enabled = false;
            Q3.GetComponent<Canvas>().enabled = false;
            Q4.GetComponent<Canvas>().enabled = true;
    
        }
    } 
}
