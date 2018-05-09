using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

    private Rigidbody2D rb;
 
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(2);
        }
    }

}
