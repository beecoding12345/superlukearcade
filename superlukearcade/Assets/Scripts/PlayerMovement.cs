using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed = 2;
    public float JumpForce = 2;
    private  Rigidbody2D _rigidbody;
    private bool isJumping;
    

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>(); // get the component that is attached to the rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        // 
        var movement = Input.GetAxis("Horizontal");
        //transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        _rigidbody.AddForce(new Vector2(movement * MovementSpeed, 0 ), ForceMode2D.Impulse);

        if (Input.GetButtonDown("Jump") && !isJumping) // jumping code for the game
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse); // adds a foce to make the player jump in the game
            isJumping = true;

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform")) // if statment to keep the player from having unlimitedjumping and keeps him on the ground after 1 jump
        {
            isJumping = false;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform")) // if statment to keep the player from having unlimitedjumping and keeps him on the ground after 1 jump
        {
            isJumping = false;
        }
    }
}
