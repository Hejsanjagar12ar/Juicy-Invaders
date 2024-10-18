using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatCounter : MonoBehaviour
{

    //TED
    public float beat = 120f;
    public int timeInBeat;
    public bool thingsCanHappen = false;

    [SerializeField] private AudioClip beatSFX;
     
    void FixedUpdate()
    {
        timeInBeat += 1;
        Debug.Log("Counting");
        if (timeInBeat == 30)
        {
            timeInBeat = 0;

            //play sound (maybe it sounds like a metronome if im lucky enough
            SoundFXManager.instance.PlaySoundFXclip(beatSFX, transform, 1f);

            Debug.Log("TIME IS NOW 30");
        }
    }
}
