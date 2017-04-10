using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    float speed = 5f;
    Animator anim;
    Rigidbody2D playerRB;
    SpriteRenderer spriteRenderer;




    // Use this for initialization
    void Awake ()
    {
        playerRB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float h = Input.GetAxisRaw("Horizontal");

        Move(h);
    }

    void Move(float h)
    {
        //refer to the current physics
        Vector2 movement = playerRB.velocity;
        movement.x = h * speed;

        // make the character move 
        playerRB.velocity = movement;


        //Check that the player is looking in the direction he's moving
        if ((h < 0f && !spriteRenderer.flipX) || (h > 0f && spriteRenderer.flipX))
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        //if h is zero, chracter is still
        //if h is not zero, chracter is moving
        bool isWalking = (h != 0f);

        //set the boolean value to the condiiton above
        anim.SetBool("isWalking", isWalking);
    }
}
