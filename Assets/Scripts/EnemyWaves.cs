using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaves : MonoBehaviour {

    Vector2 sp;
    private SpriteRenderer sprenderer;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb.GetComponent<Rigidbody2D>();
        sp = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        rb.drag =- 1;
    }

    private void OnBecameInvisible()
    {
        sprenderer = GetComponent<SpriteRenderer>();
        sprenderer.enabled = true;
        transform.position = new Vector2(sp.x + Random.Range(-10f, 10f), sp.y + 10f);       
    }
}
