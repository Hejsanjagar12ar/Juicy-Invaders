using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Missile : Projectile
{
    //Clara
    private void Awake()
    {
        direction = Vector3.down;
    }
   
    void Update()
    {
        transform.position += speed * Time.deltaTime * direction;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Boundary") || collision.gameObject.layer == LayerMask.NameToLayer("Player")) 
        {
            Destroy(gameObject); //destroy
        }
       
    }
   
}
