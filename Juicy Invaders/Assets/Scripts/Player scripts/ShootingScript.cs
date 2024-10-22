using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public Laser laserPrefab;
    Laser laser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && laser == null) 
        {
            laser = Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }
    }
}
