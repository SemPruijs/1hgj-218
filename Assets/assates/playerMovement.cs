using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;                //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;    

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector2 movement = new Vector2 (moveHorizontal, moveVertical) * Time.deltaTime;

        
        rb2d.AddForce (movement * speed);
    }

     void OnCollisionEnter2D(Collision2D col)
    {
       
        if (col.gameObject.tag == "lazer") {
            print("you did it mother fucker!");
            transform.position = new Vector2(0, 0);

            
        }

    }
}
