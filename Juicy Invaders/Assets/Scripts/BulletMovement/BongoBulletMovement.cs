using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BongoBullet : MonoBehaviour
{
    //daniel

    Rigidbody2D bongoBullet_rb;

    // Start is called before the first frame update
    void Start()
    {
        bongoBullet_rb = GetComponent<Rigidbody2D>();

        bongoBullet_rb.velocity = new Vector3(0, 7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
