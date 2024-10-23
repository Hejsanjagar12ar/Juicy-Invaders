using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarBulletMovement : MonoBehaviour
{
    float Timer = 0;

    bool Exist = false;

    // Start is called before the first frame update
    void Start()
    {
        Exist = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Exist)
        {
            Timer += Time.deltaTime;

            if(Timer > 1.5) 
            {
                Destroy(gameObject);
            }
        }
    }
}
