using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame - before rendering
	void Update () {
		
	}

    // Called before Physics updates
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal") * 10;
        float moveVertical = Input.GetAxisRaw("Vertical") * 10;

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);

        rb.velocity = movement;
    }
}
