using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    static int goldTrue = 500;
    public int gold = goldTrue;

    static int foe = 0;
    public GameObject[] foes = new GameObject[3];
    public int[] hp = new int[3];

    static int fire = 1, ice = 1, earth = 1;

    public int coins = 0;

	// Use this for initialization
	void Start ()
    {
        //checkif foe is active
        InstantiateFoe();
	}
	
	// Update is called once per frame
	void Update ()
    {
        gold = goldTrue;
	}

    public int Gold()
    {
        return gold;
    }
    public bool SpendGold(int amount)
    {
        if ((goldTrue - amount) >= 0)
        {
            goldTrue -= amount;
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
    }
    //gives foe to button
    public int FoeInt()
    {
        int got = foe;
        return got;
    }
    public void Defeat()
    {
        foe++;
        coins = 5;
    }
    public void GrabCoin()
    {
        coins--;
        if(coins == 0)
        {
            InstantiateFoe();
        }
    }


    public void Fire()
    {
        fire++;
    }
    public void Ice()
    {
        ice++;
    }
    public void Earth()
    {
        earth++;
    }
    public int GetFire()
    {
        int got = fire;
        return got;
    }
    public int GetIce()
    {
        int got = ice;
        return got;
    }
    public int GetEarth()
    {
        int got = earth;
        return got;
    }
    public int GetElement()//The weakness
    {
        return foes[foe].GetComponent<TapFoe>().ShowElement();
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
