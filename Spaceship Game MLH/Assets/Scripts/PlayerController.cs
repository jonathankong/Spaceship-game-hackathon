using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;

}

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public Boundary boundary;

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

        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax),
            0.0f
        );
    }
}
