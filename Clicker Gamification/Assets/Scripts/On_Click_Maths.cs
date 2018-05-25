using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class On_Click_Maths : MonoBehaviour {

    //Canvases
    public Canvas Q1, Q2, Q3;
    public Toggle Q1A1, Q1A2, Q1A3, Q1A4, Q2A1, Q2A2, Q2A3, Q2A4, Q3A1, Q3A2, Q3A3, Q3A4;
    private int listno = 0;
    private int listnoToggle = 0;
    private int Q1correct, Q2correct, Q3correct, score, goldTally, goldInitial;
    public Text scoretext, goldText;

	// Use this for initialization
	void Start () {

        Q1correct = 0;
        Q2correct = 0;
        Q3correct = 0;
        score = 0;
        goldInitial = 100;
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

        scoretext.text = "Correct questions: " + score + "/3";
        goldTally = goldInitial + 100 * score;
        goldText.text = "You earned +" + goldTally + " gold";

	}

    //check if listno > 4 and jump back to scroll selection if so otherwise increment listno.
    public void OnClick_Continue() { 
        if (listno > 2) { 
        
            GameManager.instance.SpendGold(-(100+100*score)); 
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

    //changes which of the canvases is visable
    private void ChangeVisableCanvas() { 

        //if Reading is the active canvas
        if (listno == 0) {
    
            Q1.GetComponent<Canvas>().enabled = true;
            Q2.GetComponent<Canvas>().enabled = false;
            Q3.GetComponent<Canvas>().enabled = false;
    
        }

        //if Q1 is the active canvas
        if (listno == 1) {
    
            Q1.GetComponent<Canvas>().enabled = false;
            Q2.GetComponent<Canvas>().enabled = true;
            Q3.GetComponent<Canvas>().enabled = false;
    
        }

        //if Q2 is the active canvas
        if (listno == 2) {
    
            Q1.GetComponent<Canvas>().enabled = false;
            Q2.GetComponent<Canvas>().enabled = false;
            Q3.GetComponent<Canvas>().enabled = true;
    
        }
    } 
}