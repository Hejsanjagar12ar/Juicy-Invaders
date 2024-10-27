using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //Ted
    public float speed = 10f; // Speed of the bullet

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // Apply velocity in the forward direction of the bullet's transform
            rb.velocity = transform.up * speed;
        }
        else
        {
            Debug.LogWarning("Rigidbody missing on bullet prefab: " + gameObject.name);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Boundary") || collision.gameObject.layer == LayerMask.NameToLayer("Invader"))
        {
            Destroy(gameObject);
        }
    }
}