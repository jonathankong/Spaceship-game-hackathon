using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Boundary boundary;
    public Transform shootPoint;
    public GameObject bullet;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(shoot());
    }
	
	// Update is called once per frame
	void Update () {

    }

    IEnumerator shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.25f);
            Instantiate(bullet, shootPoint.position, Quaternion.identity);
        }
    }
}
