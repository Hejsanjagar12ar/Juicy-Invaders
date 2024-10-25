using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    float amplitude;
    float elapsedTime;
    float shakeTime;
    Vector3 originalPosition;

    public IEnumerator Shake(float shakeTime, float amplitude) 
    {
        Vector3 originalPosition = transform.localPosition;

        float elpasedTime = 0.0f;

        while(elapsedTime < shakeTime) 
        {
            Vector2 offset = Random.insideUnitCircle * amplitude;

            transform.localPosition = new Vector3(offset.x, offset.y, originalPosition.z);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
