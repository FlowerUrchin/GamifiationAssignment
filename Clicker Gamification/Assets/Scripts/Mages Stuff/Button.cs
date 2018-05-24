using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    public Text damage;
    int dam, curText = 0;
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
        dam = GameManager.instance.foes[GameManager.instance.FoeInt()].GetComponent<TapFoe>().Tap();
        damage.text = "" + dam;
        time = Time.time + 0.07f;

    }
}
