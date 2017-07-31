using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyEntity : MonoBehaviour {

    public int maxHP;
    public int currentHP;
    public int baseDefence;
    public int currentDefence;
    public int mainAttack;
    public AudioClip hurtClip;
    public AudioClip introClip;
    public AudioClip attackClip;
    public AudioClip defeatClip;

    public class Attack
    {
        public int damage;
    }

    public Attack[] attacks;


    private PlayerHealth playerHealth;

	// Use this for initialization
	void Start () {
        playerHealth = FindObjectOfType<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void enemyAttack(int inValue)
    {
        //int i = chosenAttack.damage;
        Debug.Log("Enemy attacked player for " + inValue);
        playerHealth.ChangeHealth(inValue);
    }

    public virtual void changeHealth(int inValue)
    {
        Debug.Log("Enemy was attack for " + inValue + " and has " + currentHP + " left.");
        currentHP -= inValue;
    }
}
