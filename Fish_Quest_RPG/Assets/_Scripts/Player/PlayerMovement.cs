using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Entity {

    public bool canMove;

    public string startPoint;
    public float diagonalMoveModifier;

    private float currentMoveSpeed;
    private Rigidbody2D rb2D;
    private Animator anim;
    private SpriteRenderer playerRenderer;

    private static bool playerExists;
    private DialogueManager dMan;
    private Vector2 moveInput;

    private void Awake()
    {
        //canMove = true;
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponentInChildren<Animator>();
        playerRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Use this for initialization
    void Start () {


        
        if(!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        

        
        
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!dMan.dialogueActive)
        {
            canMove = true;
        }

        if(!canMove)
        {
            rb2D.velocity = Vector2.zero;
            return;
        }

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        
        if(moveInput != Vector2.zero)
        {
            rb2D.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
            anim.SetBool("IsWalking", true);
            if (Input.GetAxisRaw("Horizontal") > 0.5f)
            {
                playerRenderer.flipX = false;
            }
            else if (Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                playerRenderer.flipX = true;
            }
        } else
        {
            rb2D.velocity = Vector2.zero;
            anim.SetBool("IsWalking", false);
        }


        /*
        if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));


            rb2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * currentMoveSpeed, rb2D.velocity.y);
            anim.SetBool("IsWalking", true);
            if (Input.GetAxisRaw("Horizontal") > 0.5f)
            {
                playerRenderer.flipX = false;
            }
            else if(Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                playerRenderer.flipX = true;
            }
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));


            rb2D.velocity = new Vector2(rb2D.velocity.x, Input.GetAxisRaw("Vertical") * currentMoveSpeed);
            anim.SetBool("IsWalking", true);

        }
        if(Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            rb2D.velocity = new Vector2(0f, rb2D.velocity.y);

        }
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, 0f);

        }
        */

        /*
        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0.5f && Mathf.Abs(Input.GetAxisRaw("Vertical")) > 0.5f)
        {
            currentMoveSpeed = moveSpeed * diagonalMoveModifier;
        }
        else
        {
            currentMoveSpeed = moveSpeed;
        }
        */


        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5 && Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            anim.SetBool("IsWalking", false);
        }

        
    }

}


