using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    // 1 - Designer variables

    /// <summary>
    /// Object speed
    /// </summary>
    public Vector2 speed = new Vector2(10, 10);

    /// <summary>
    /// Moving direction
    /// </summary>
    public Vector2 direction = new Vector2(-1, 0);

    [SerializeField]
    float frequency = 20f;
    [SerializeField]
    float magnitude = 0.5f;

    bool facingRight = true;
    Vector2 pos, localScale;

    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    void Start()
    {
        pos = transform.position;
        localScale = transform.localScale;
    }

    void Update()
    {
        float sinWaveValue = Mathf.Sin(Time.time * frequency);
        Quaternion theRotation = transform.localRotation;
        // 2 - Movement
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y + sinWaveValue * magnitude);
        Debug.Log("Normal Sine Wave =" + sinWaveValue * 45);
        Debug.Log("Faster Sine Wave =" + Mathf.Sin(Time.time * frequency / 2) * 0.5f * 45);
        transform.eulerAngles = new Vector3(0, 0, -Mathf.Sin(Time.time * frequency) * 0.5f * 45);
        //transform.localRotation = theRotation;

    }

    void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // Apply movement to the rigidbody
        rigidbodyComponent.velocity = movement;

    }


}
