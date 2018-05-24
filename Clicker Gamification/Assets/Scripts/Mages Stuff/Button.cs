using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    public Text damage;
    int curText = 0;
    float time = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Time.time >= time)
        {
            damage.text = "";
        }		
	}
    public void hit()
    {
        if(GameManager.instance.GetElement() == 0)
        {
            damage.color = Color.white;
        }
        else if (GameManager.instance.GetElement() == 1)
        {
            damage.color = Color.red;
        }
        else if (GameManager.instance.GetElement() == 2)
        {
            damage.color = Color.cyan;
        }
        else if (GameManager.instance.GetElement() == 3)
        {
            damage.color = Color.green;
        }
        damage.text = ""+GameManager.instance.foes[GameManager.instance.FoeInt()].GetComponent<TapFoe>().Tap();
        time = Time.time + 0.07f;

    }
}
