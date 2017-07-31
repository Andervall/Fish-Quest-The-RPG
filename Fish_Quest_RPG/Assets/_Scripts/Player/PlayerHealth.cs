using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHealth;

    //private static bool healthSystemExists;

    // Use this for initialization
    void Start () {
        playerCurrentHealth = playerMaxHealth;

        /*
        if (!healthSystemExists)
        {
            healthSystemExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        */
    }
	
	// Update is called once per frame
	void Update () {
		//if(playerCurrentHealth > playerMaxHealth){ SetMaxHealth(); }


	}

    public void ChangeHealth(int inValue)
    {
        //Vi adderar värde till current. Dvs för att ta skada, skriv -10, för att heala, skriv 10.
        playerCurrentHealth += inValue;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
