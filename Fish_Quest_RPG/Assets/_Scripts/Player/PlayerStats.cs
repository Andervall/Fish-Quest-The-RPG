using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int currentLevel;
    public int currentExp;

    public int[] toLevelup;

    public int[] HPLevels;
    public int[] attackLevels;
    public int[] defenceLevels;

    public int currentHP;
    public int currentAttack;
    public int currentDefence;

    private PlayerHealth playerHealth;

	// Use this for initialization
	void Start () {
        currentHP = HPLevels[1];
        currentAttack = attackLevels[1];
        currentDefence = defenceLevels[1];

        playerHealth = FindObjectOfType<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		if(currentExp >= toLevelup[currentLevel])
        {
            LevelUp();
        }
	}

    public void AddExperience(int inValue)
    {
        currentExp += inValue;
    }

    public void LevelUp()
    {
        currentLevel++;
        currentHP = HPLevels[currentLevel];
        currentAttack = attackLevels[currentLevel];
        currentDefence = defenceLevels[currentLevel];
        playerHealth.playerMaxHealth = currentHP;
        playerHealth.playerCurrentHealth = currentHP;
        //Lägger på skillnaden mellan levelarna i HP
        //playerHealth.playerCurrentHealth += currentHP - HPLevels[currentLevel - 1];
    }
}
