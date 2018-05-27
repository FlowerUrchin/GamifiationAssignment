using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magetowerinstructionsbutton : MonoBehaviour {
    public Canvas instructions;
	// Use this for initialization
	void Start () {
        print(instructions.enabled);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnOffInstructions() { 
    
       if (instructions.enabled == false) { 
    
            instructions.enabled = true;
            print("reached 1");
            print(instructions.enabled);

       } 
       
       else if (instructions.enabled == true) { 
    
            instructions.enabled = false;
            print("reached 2");
            print(instructions.enabled);
        }

    }
}
