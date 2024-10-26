using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    
    //Daniel
    //Ted

    [SerializeField] GameObject bongoBullet;
    [SerializeField] GameObject drumsBullet;
    [SerializeField] GameObject guitarBullet;
    [SerializeField] GameObject saxBullet;
    [SerializeField] GameObject accordionBullet;
    bool Bongo = true;
    bool Drums = true;
    bool Guitar = true;
    bool Sax = true;
    bool Accordion = true;
    int bongoCD;
    int drumsCD;
    int guitarCD;
    int saxCD;
    int accordionCD;
    BeatCounter bc;

    private void Start()
    {
        //Gets refference to the BeatManager to make player move on beat.
        bc = GameObject.Find("BeatManager").GetComponent<BeatCounter>();
    }
    void Update()
    {
        if (Bongo)
        {
            if (bc.timeInBeat == 30)
            {
                Instantiate(bongoBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
        }

        if (Drums)
        {
            if (bc.timeInBeat == 30)
            {
                Instantiate(drumsBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
        }

        if (Guitar)
        {
            if (bc.timeInBeat == 30)
            {
                Instantiate(guitarBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
        }

        if (Sax)
        {
            if (bc.timeInBeat == 30)
            {
                Instantiate(saxBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
        }

        if (Accordion)
        {
            if (bc.timeInBeat == 30)
            {
                Instantiate(accordionBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
        }
    }
}
