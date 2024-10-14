using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //TED

    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public Transform movePoint;

    // Start is called before the first frame update
    void Start()
    {
        //Makes "movePoint" not be part of the parent anymore
        movePoint.parent = null;

    }

    // Update is called once per frame
    void Update()
    {
        //Moves the "movePoint" to where we want to go and then starts moving player towoards it
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1)
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
            }

            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1)
            {
                movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
            }
        }
        
    }
}
