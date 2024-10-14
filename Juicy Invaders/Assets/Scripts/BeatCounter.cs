using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatCounter : MonoBehaviour
{

    //TED
    public float beat = 120f;
    public int timeInBeat;
    public bool thingsCanHappen = false;
    
    void FixedUpdate()
    {
        timeInBeat += 1;
        Debug.Log("Counting");
        if (timeInBeat == 30)
        {
            timeInBeat = 0;

            Debug.Log("TIME IS NOW 30");

        }
    }
}
