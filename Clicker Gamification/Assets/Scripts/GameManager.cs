using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public int gold = 500;
    int foe = 0;
    public GameObject[] foes = new GameObject[1];
    public int[] hp = new int[1];
	// Use this for initialization
	void Start ()
    {
        InstantiateFoe();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public int Gold()
    {
        return gold;
    }
    public bool SpendGold(int amount)
    {
        if ((gold - amount) >= 0)
        {
            gold -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
    //Activate Foe
    public void InstantiateFoe()
    {
        foes[foe].GetComponent<TapFoe>().Create(hp[foe]);
        foe++;
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
    }
}
