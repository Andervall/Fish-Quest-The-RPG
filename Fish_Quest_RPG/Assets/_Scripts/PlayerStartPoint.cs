using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

    public string pointName;

    private PlayerMovement player;
    private CameraController cameraController;

  

	// Use this for initialization
	void Start () {
        
        player = FindObjectOfType<PlayerMovement>();

        if(player.startPoint == pointName)
        {
            cameraController = FindObjectOfType<CameraController>();
            player.transform.position = transform.position;
            cameraController.transform.position = new Vector3(transform.position.x, transform.position.y, cameraController.transform.position.z);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
