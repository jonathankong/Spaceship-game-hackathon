using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class EnemyScript : MonoBehaviour
{
    // 1 - Designer variables

    /// <summary>
    /// Object speed
    /// </summary>
    public Vector2 speed = new Vector2(5, 5);
    public Vector2 direction = new Vector2(-1, 0);
    public float frequency = 5f;
    public float magnitude = 10f;

    /// <summary>
    /// Moving direction
    /// </summary>
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    void Update()
    {
        // 2 - Movement
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y + Mathf.Sin(Time.time * frequency) * magnitude);
        transform.eulerAngles = new Vector3(0, 0, -Mathf.Sin(Time.time * frequency) * 0.5f * 45);

    }

    void FixedUpdate()
    {
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // Apply movement to the rigidbody
        rigidbodyComponent.velocity = movement;
    }
}