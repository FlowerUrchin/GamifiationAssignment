using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnClick_Scrolls_Continue : MonoBehaviour {

    //Canvases
    public Canvas Reading, Q1, Q2, Q3, Q4;
    public Toggle Q1A1, Q1A2, Q1A3, Q1A4, Q2A1, Q2A2, Q2A3, Q2A4, Q3A1, Q3A2, Q3A3, Q3A4, Q4A1, Q4A2, Q4A3, Q4A4;
    public List<Canvas> CanvasList;
    public List<Toggle> ToggleList;
    private int listno = 0;
    private int listnoToggle = 0;
    private int Q1correct, Q2correct, Q3correct, Q4correct, score;
    public Text scoretext;

	// Use this for initialization
	void Start () {
		CanvasList = new List<Canvas>{Reading, Q1, Q2, Q3, Q4};
        ToggleList = new List<Toggle>{Q1A1, Q1A2, Q1A3, Q1A4, Q2A1, Q2A2, Q2A3, Q2A4, Q3A1, Q3A2, Q3A3, Q3A4, Q4A1, Q4A2, Q4A3, Q4A4};

        Q1correct = 0;
        Q2correct = 0;
        Q3correct = 0;
        Q4correct = 0;
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        ChangeVisableCanvas();

        if (Q1correct == 1) { 

            Q1A1.interactable = false;
            Q1A2.interactable = false;
            Q1A3.interactable = false;
            Q1A4.interactable = false;
            score++;
            Q1correct = 0;

        }

        if (Q2correct == 1) { 
    
            Q2A1.interactable = false;
            Q2A2.interactable = false;
            Q2A3.interactable = false;
            Q2A4.interactable = false;
            score++;
            Q2correct = 0;

        }

        if (Q3correct == 1) { 
    
            Q3A1.interactable = false;
            Q3A2.interactable = false;
            Q3A3.interactable = false;
            Q3A4.interactable = false;    
            score++;
            Q3correct = 0;

        }

        if (Q4correct == 1) { 
    
            Q4A1.interactable = false;
            Q4A2.interactable = false;
            Q4A3.interactable = false;
            Q4A4.interactable = false;
            score++;
            Q4correct = 0;
        
        }

        scoretext.text = "Correct questions: " + score + "/4";

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

    //toggle buttons Q1
    public void OnClick_Q1A1() { 
         if (Q1A1.isOn == true) { 
            Q1A1.GetComponentInChildren<Text>().text = "WRONG!";
            Q1A1.interactable = false;
         }
    }

    public void OnClick_Q1A2() {
        if (Q1A2.isOn == true) { 
            Q1A2.interactable = false;
            Q1A2.GetComponentInChildren<Text>().text = "CORRECT!";
            Q1correct = 1;
        }
    }

    public void OnClick_Q1A3() { 
        if (Q1A3.isOn == true) { 
            Q1A3.GetComponentInChildren<Text>().text = "WRONG!";
            Q1A3.interactable = false;
        }
    }

    public void OnClick_Q1A4() { 
        if (Q1A4.isOn == true) { 
            Q1A4.GetComponentInChildren<Text>().text = "WRONG!";
            Q1A4.interactable = false;
        }
    }

    //toggle buttons Q2
    public void OnClick_Q2A1() { 
        if (Q2A1.isOn == true) { 
            Q2A1.interactable = false;
            Q2A1.GetComponentInChildren<Text>().text = "CORRECT!";
            Q2correct = 1;
        }
    }
    
    public void OnClick_Q2A2() {
        if (Q2A2.isOn == true) { 
            Q2A2.GetComponentInChildren<Text>().text = "WRONG!";
            Q2A2.interactable = false;
        }
    }

    public void OnClick_Q2A3() { 
        if (Q2A3.isOn == true) { 
            Q2A3.GetComponentInChildren<Text>().text = "WRONG!";
            Q2A3.interactable = false;
        }
    }

    public void OnClick_Q2A4() { 
        if (Q2A4.isOn == true) { 
            Q2A4.GetComponentInChildren<Text>().text = "WRONG!";
            Q2A4.interactable = false;
        }
    }

    //toggle buttons Q3
    public void OnClick_Q3A1() { 
        if (Q3A1.isOn == true) { 
            Q3A1.GetComponentInChildren<Text>().text = "WRONG!";
            Q3A1.interactable = false;
        }
    }
    
    public void OnClick_Q3A2() { 
        if (Q3A2.isOn == true) { 
            Q3A2.GetComponentInChildren<Text>().text = "WRONG!";
            Q3A2.interactable = false;
        }
    }

    public void OnClick_Q3A3() {
        if (Q3A3.isOn == true) { 
            Q3A3.GetComponentInChildren<Text>().text = "CORRECT!";
            Q3A3.interactable = false;
            Q3correct = 1;
        }
    }

    public void OnClick_Q3A4() {
        if (Q3A4.isOn == true) { 
            Q3A4.GetComponentInChildren<Text>().text = "WRONG!";
            Q3A4.interactable = false;
        }
    }

    //toggle buttons Q4
    public void OnClick_Q4A1() { 
        if (Q4A1.isOn == true) { 
            Q4A1.interactable = false;
            Q4A1.GetComponentInChildren<Text>().text = "CORRECT!";
            Q4correct = 1;
        }
    }
    
    public void OnClick_Q4A2() { 
        if (Q4A2.isOn == true) { 
            Q4A2.GetComponentInChildren<Text>().text = "WRONG!";
            Q4A2.interactable = false;
        }
    }

    public void OnClick_Q4A3() { 
        if (Q4A3.isOn == true) { 
            Q4A3.GetComponentInChildren<Text>().text = "WRONG!";
            Q4A3.interactable = false;
        }
    }

    public void OnClick_Q4A4() {
        if (Q4A4.isOn == true) { 
            Q4A4.GetComponentInChildren<Text>().text = "WRONG!";
            Q4A4.interactable = false;
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