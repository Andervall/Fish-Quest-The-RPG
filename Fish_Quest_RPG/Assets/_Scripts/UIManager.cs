using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Slider healthBar;
    public Text hpText;
    public PlayerHealth playerhealth;
    public Text levelText;
    public Text expText;
    public Text attackText;
    public Text defenceText;

    private PlayerStats playerStats;
    private static bool UIExists;

    // Use this for initialization
    void Start () {
        playerStats = GetComponent<PlayerStats>();
        if (!UIExists)
        {
            UIExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        healthBar.maxValue = playerhealth.playerMaxHealth;
        healthBar.value = playerhealth.playerCurrentHealth;
        hpText.text = "Livspoäng: " + playerhealth.playerCurrentHealth + "/" + playerhealth.playerMaxHealth;
        levelText.text = "Level: " + playerStats.currentLevel;
        expText.text = "Erfarenhetspoäng: " + playerStats.currentExp + "/" + playerStats.toLevelup[playerStats.currentLevel];
        attackText.text = "" + playerStats.currentAttack;
        defenceText.text = "" + playerStats.currentDefence;


	}
}
