using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
        float input = Input.GetAxis("Horizontal");

        Movement(input);

        foreach (Touch touch in Input.touches)
        {
            if (touch.position.x < Screen.width / 2)
            {
                rb.velocity = new Vector2(-10f, 0);
            }
            else if (touch.position.x > Screen.width / 2)
            {
                rb.velocity = new Vector2(+10f, 0);
            }
        }


    }

    private void Movement(float input)
    {
        if (transform.position.x <= -9f)
        {
            rb.transform.position = new Vector2(-9f, transform.position.y);
            rb.velocity = new Vector2(input * 10f, 0);
        } 
        else if(transform.position.x >= 9f)
        {
            rb.transform.position = new Vector2(9f, transform.position.y);
            rb.velocity = new Vector2(input * 10f, 0);
        }
        else
        {
            rb.velocity = new Vector2(input * 10f, 0);
        }
    }

}
