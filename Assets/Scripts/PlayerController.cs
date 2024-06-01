using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed;
    private float jumpSpeed;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        moveSpeed = 2f;
        jumpSpeed = 60f;
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if(moveHorizontal> 0.1f || moveHorizontal< -0.1f)
        {
            rb.AddForce(new Vector2(moveHorizontal* moveSpeed, 0f), ForceMode2D.Impulse);
        }    
    }
}
