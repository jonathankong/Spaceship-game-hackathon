using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;

}

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rb;
    public Boundary boundary;
    public Transform shootPoint;
    public GameObject bullet;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(shoot());
	}

    // Update is called once per frame - before rendering
    void Update() {
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

    IEnumerator shoot()
    {
        while (true) { 
            yield return new WaitForSeconds(0.25f);
            Instantiate(bullet, shootPoint.position, Quaternion.identity);
        }
    }
}
