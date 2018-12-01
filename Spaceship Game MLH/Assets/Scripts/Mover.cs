using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.forward * speed;
        Destroy(this.gameObject, 2f);
	}
	
	// Update is called once per frame
	void Update () {

        rb.velocity = transform.right * speed;

    }
}
