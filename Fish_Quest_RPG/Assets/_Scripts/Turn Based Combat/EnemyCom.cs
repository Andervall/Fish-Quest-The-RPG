using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCom : MonoBehaviour {

    public GameObject currentEnemy;
    public EnemyEntity enemyEntity;

	// Use this for initialization
	void Start () {
        currentEnemy = GameObject.FindGameObjectWithTag("Enemy");

	}
	
	// Update is called once per frame
	void Update () {
		if(BattleFlow.TurnCounter==2)
        {
            Debug.Log("!!! Fienden attackerar på sin tur!");
            
            BattleFlow.TurnCounter = 1;
            StartCoroutine(EndEnemyTurn());
        }
	}

    IEnumerator EndEnemyTurn()
    {
        yield return new WaitForSeconds(1);
        
    }
}
