using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    //Ted
    //Anton
    //Daniel

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
    BeatCounter bc;

    [SerializeField] AudioClip bongoShootSFX;
    [SerializeField] AudioClip drumsShootSFX;
    [SerializeField] AudioClip guitarShootSFX;
    [SerializeField] AudioClip saxShootSFX;
    [SerializeField] AudioClip accordionShootSFX;

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
                SoundFXManager.instance.PlaySoundFXclip(bongoShootSFX, transform, 1f);
                Instantiate(bongoBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
        }

        if (Drums)
        {
            if (bc.timeInBeat == 27)
            {
                SoundFXManager.instance.PlaySoundFXclip(drumsShootSFX, transform, 1f);
                Instantiate(drumsBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
        }

        if (Guitar)
        {
            if (bc.timeInBeat == 10)
            {
                SoundFXManager.instance.PlaySoundFXclip(guitarShootSFX, transform, 1f);
                Instantiate(guitarBullet, transform.position + new Vector3(1, 1, 0), Quaternion.identity);
            }
            else if (bc.timeInBeat == 20)
            {
                SoundFXManager.instance.PlaySoundFXclip(guitarShootSFX, transform, 1f);
                Instantiate(guitarBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
            else if (bc.timeInBeat == 30)
            {
                SoundFXManager.instance.PlaySoundFXclip(guitarShootSFX, transform, 1f);
                Instantiate(guitarBullet, transform.position + new Vector3(-1, 1, 0), Quaternion.identity);
            }
        }

        if (Sax)
        {
            if (bc.timeInBeat == 10)
            {
                SoundFXManager.instance.PlaySoundFXclip(saxShootSFX, transform, 1f);
                Instantiate(saxBullet, transform.position + new Vector3(0.5f, 1, 0), Quaternion.identity);
            }
            else if (bc.timeInBeat == 20)
            {
                SoundFXManager.instance.PlaySoundFXclip(saxShootSFX, transform, 1f);
                Instantiate(saxBullet, transform.position + new Vector3(-0.5f, 1, 0), Quaternion.identity);
            }
        }

        if (Accordion)
        {
            if (bc.timeInBeat == 25)
            {
                SoundFXManager.instance.PlaySoundFXclip(accordionShootSFX, transform, 1f);
                Instantiate(accordionBullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            }
        }
    }
}
