using UnityEngine;

public class Lazer : MonoBehaviour
{
    public float speed = 10f;  // Speed at which the projectile will travel

    void Update()
    {
        // Move the projectile upwards in 2D space
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Destroy the projectile when it hits an object
        if (collision.CompareTag("Enemy"))  // Adjust the tag based on your enemies
        {
            Destroy(collision.gameObject);  // Destroy the enemy
            Destroy(gameObject);            // Destroy the projectile
        }
    }
}
