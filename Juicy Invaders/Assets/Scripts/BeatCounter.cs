using UnityEngine;

public class BeatCounter : MonoBehaviour
{
    //TED 

    public float beat = 120f; // Beats per minute
    public int timeInBeat;
    public bool thingsCanHappen = false;

    [SerializeField] private AudioClip beatSFX;

    private float timeElapsed;
    private float secondsPerBeat;

    private void Start()
    {
        // Calculate the duration of each beat in seconds
        secondsPerBeat = 60f / beat;
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= secondsPerBeat)
        {
            timeInBeat = 30; // Set to 30 when the beat is reached
            Debug.Log("TIME IS NOW 30");

            // Reset timer for the next beat
            timeElapsed = 0f;
        } else
          {
            timeInBeat = (int)(30 * (timeElapsed / secondsPerBeat)); // Scales timeInBeat within 0-30
          }
    }
}