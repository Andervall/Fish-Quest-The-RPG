﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudBoundryRemoval : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("MM_Cloud"))
        {
            Destroy(collision.gameObject);
        }
    }
}
