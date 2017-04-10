using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    float speed = 5f;
    Rigidbody2D playerRB;

	// Use this for initialization
	void Awake ()
    {
        playerRB = GetComponent<Rigidbody2D>();

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
    }
}
