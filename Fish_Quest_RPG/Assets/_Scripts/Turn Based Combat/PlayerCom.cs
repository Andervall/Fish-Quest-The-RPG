using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("1") && (BattleFlow.TurnCounter==1))
        {
            Debug.Log("!!! Player pressed 1 on his turn");
           
            StartCoroutine(EndPlayerTurn());
        }
	}

    IEnumerator EndPlayerTurn()
    {
        yield return new WaitForSeconds(1);
        BattleFlow.TurnCounter = 2;

    }
}
