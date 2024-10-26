using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    
    //Daniel
    //Ted

    [SerializeField] 
    GameObject bongoBullet;
    [SerializeField]
    GameObject drumsBullet;
    [SerializeField]
    GameObject guitarBullet;
    [SerializeField]
    GameObject saxBullet;
    [SerializeField]
    GameObject accordionBullet;
    bool Bongo = true;
    bool Drums = false;
    bool Guitar = false;
    bool Sax = false;
    bool Accordion = false;
    float Timer = 0;
    int bongoCD;
    int drumsCD;
    int guitarCD;
    int saxCD;
    int accordionCD;

    void Update()
    {
        Timer += Time.deltaTime;

        if (Bongo)
        {
            if (((int)Timer % 2) == 0 && (int)Timer != bongoCD)
            {
                Instantiate(bongoBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);

                bongoCD = (int)Timer;
            }
        }

        if (Drums)
        {
            if (((int)Timer % 4) == 0 && (int)Timer != drumsCD)
            {
                Instantiate(drumsBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);

                drumsCD = (int)Timer;
            }
        }

        if (Guitar)
        {
            if (((int)Timer % 6) == 0 && (int)Timer != guitarCD)
            {
                Instantiate(guitarBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);

                guitarCD = (int)Timer;
            }
        }

        if (Sax)
        {
            if (((int)Timer % 8) == 0 && (int)Timer != saxCD)
            {
                Instantiate(saxBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);

                saxCD = (int)Timer;
            }
        }

        if (Accordion)
        {
            if (((int)Timer % 10) == 0 && (int)Timer != accordionCD)
            {
                Instantiate(accordionBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);

                accordionCD = (int)Timer;
            }
        }
    }
}
