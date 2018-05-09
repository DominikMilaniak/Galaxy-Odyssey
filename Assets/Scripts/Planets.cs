using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour {

    Vector2 sp;
    public GameObject Planet;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb.GetComponent<Rigidbody2D>();
        sp = transform.position;
    }
	
	// Update is called once per frame
	void Update () {

    }

    private void OnBecameInvisible()
    {
        transform.position = new Vector2(sp.x + Random.Range(-10f, 10f), sp.y + 10f);
        int random = Random.Range(0, 4);
        transform.localScale = new Vector3(random, random, 0);
        var rotate = transform.eulerAngles;
        rotate.z = Random.Range(0, 360);
        transform.eulerAngles = rotate;
    }
}
