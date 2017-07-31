using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour {

    public string levelToLoad;
    public string exitPoint;

    private PlayerMovement player;
    
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(levelToLoad);
            //Application.LoadLevel(levelToLoad);
            player.startPoint = exitPoint;
        }
    }
}
