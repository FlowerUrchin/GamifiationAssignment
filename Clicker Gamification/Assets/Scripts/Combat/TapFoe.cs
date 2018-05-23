using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapFoe : MonoBehaviour
{
    int health, maxHealth;
    public Slider enemyHealth;
    bool active = false;
    public bool clicked = false;

    public int element = 0;//Weakness: 1 Fire, 2 Ice, 3 Earth 
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(active)
        {
            enemyHealth.value = health;
            if (health <= 0)
            {
                //Reward Popup

                //Add Gold
                GameManager.instance.SpendGold(-10 * maxHealth);
                //Hide and Deactivate
                active = false;
                GameManager.instance.Defeat();
                GameManager.instance.InstantiateFoe();
                gameObject.SetActive(false);
                //Alert GameManager to change

            }
        }
	}
    public void Tap()
    {
        if(element == 1)
        {
            health -= GameManager.instance.GetFire();
        }
        else if (element == 2)
        {
            health -= GameManager.instance.GetFire();
        }
        else if (element == 3)
        {
            health -= GameManager.instance.GetFire();
        }
        else
        {
            health--;
        }
        clicked = true;
    }
    public void Create(int hp)
    {
        maxHealth = hp;
        health = hp;
        enemyHealth.maxValue = hp;
        active = true;
        gameObject.SetActive(true);
    }
}
