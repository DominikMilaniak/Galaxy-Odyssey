using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    private Rigidbody2D rb;
    Vector2 sp;
    private SpriteRenderer sprenderer;
    public GameObject PlayerModel;
	// Use this for initialization
	void Start () {
        rb.GetComponent<Rigidbody2D>();
        sp = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(0, 10f);
        transform.position = new Vector2(PlayerModel.transform.position.x, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            sprenderer = collision.gameObject.GetComponent<SpriteRenderer>();
            sprenderer.enabled = false;
        }
    }

    private void OnBecameInvisible()
    {
        sprenderer.enabled = true;
        transform.position = new Vector2(PlayerModel.transform.position.x, sp.y);
    }
}
