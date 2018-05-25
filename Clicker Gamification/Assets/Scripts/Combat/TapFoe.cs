using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapFoe : MonoBehaviour
{
    int health, maxHealth;
    public Slider enemyHealth;
    public GameObject[] coin = new GameObject[5];
    bool active = false;
    public bool clicked = false;
    public int identity;

    Animator animator;
    Animation knock;

    public int element = 0;//Weakness: 1 Fire, 2 Ice, 3 Earth 
	// Use this for initialization
	void Start ()
    {
        if(identity == 1)
        {
            animator = GetComponent<Animator>();
        }
        if(identity == 2)
        {
            knock = GetComponent<Animation>();
        }
        if(identity == 3)
        {
            animator = GetComponent<Animator>();
            knock = GetComponent<Animation>();
        }
        if(identity == 4)
        {
            animator = GetComponent<Animator>();
        }
        
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
                //GameManager.instance.SpendGold(-10 * maxHealth);
                //Hide and Deactivate
                active = false;
                GameManager.instance.Defeat();
                //Creates coins:
                for(int i =0; i < 5; i++)
                {
                    coin[i].GetComponent<CoinChange>().SetValue(10 * maxHealth / 5);
                }
                //GameManager.instance.InstantiateFoe();
                gameObject.SetActive(false);
                //Alert GameManager to change

            }
            if(clicked == true)
            {
                clicked = false;
                //animator.SetBool("Attack", false);
            }
        }
	}
    public int Tap()
    {
        int dam;
        clicked = true;
        if(identity == 1)
        {
            animator.Play("Knockback");
        }
        if(identity == 2)
        {
            knock.Play("hit1");
        }
        if(identity == 3)
        {
            animator.Play("SlimeDie");
        }
        if(identity == 4)
        {
            animator.Play("BatHit");
        }
        //animator.SetBool("Attack", true);
        if (element == 1)
        {
            dam = GameManager.instance.GetFire();
        }
        else if (element == 2)
        {
            dam = GameManager.instance.GetIce();
        }
        else if (element == 3)
        {
            dam = GameManager.instance.GetEarth();
        }
        else
        {
            dam = (GameManager.instance.GetFire()+GameManager.instance.GetIce()+GameManager.instance.GetEarth())/3;
        }
        health -= dam;
        return dam;
        
        

    }

    public int ShowElement()
    {
        return element;
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
