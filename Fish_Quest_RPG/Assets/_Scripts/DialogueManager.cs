using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;
    public bool dialogueActive;
    public Image dImage;
    public string imageName;


    public int currentLine;
    public string[] dialogueLines;
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (dialogueActive && Input.GetKeyUp(KeyCode.Space))
        {
            //dBox.SetActive(false);
            //dialogueActive = false;

            currentLine++;
            
        }
        if(currentLine >= dialogueLines.Length)
        {
            dBox.SetActive(false);
            dialogueActive = false;

            currentLine = 0;
        }

        dText.text = dialogueLines[currentLine];
    }

    public void ShowDialogue()
    {
        dBox.SetActive(true);
        dialogueActive = true;
    }

    /* OUT-DATED
    public void ShowBox(string inText)
    {
        dBox.SetActive(true);
        dialogueActive = true;
        dText.text = inText;
        //dImage = Resources.Load(imageIn);
    }
    */
}
