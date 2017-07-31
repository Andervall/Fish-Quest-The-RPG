using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {

    public string dialogue;
    public string[] dialogueHolderLines;

    private PlayerMovement playerMovement;
    private DialogueManager dMan;
    

	// Use this for initialization
	void Start () {
        dMan = FindObjectOfType<DialogueManager>();
        playerMovement = FindObjectOfType<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                //dMan.ShowBox(dialogue);
                if(!dMan.dialogueActive)
                {
                    dMan.dialogueLines = dialogueHolderLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                    playerMovement.canMove = false;
                }
            }
        }
    }
}
