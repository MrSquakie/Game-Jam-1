using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleJump : MonoBehaviour
{
    // Start is called before the first frame update
   
    public int maxJump = 2;
    int jumps;

    public float moveSpeed = 10f;
    public float jumpforce = 10f;

    public bool grounded;



    void Start()
    {
        jumps = maxJump;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }
    void Jump()
    {
        if (jumps > 0)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            grounded = false;
            jumps = jumps - 1;
        }
        if (jumps == 0)
        {
            return;
        }
    }
    void OnCollisionEnter2D(Collision2D collide)
    {
        if (collide.gameObject.tag == "Ground")
        {
            jumps = maxJump;
            grounded = true;
            moveSpeed = 2.0F;
        }
    }
   
    
      void GoUp()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        jumps = jumps - 1;
    }

}
