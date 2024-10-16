using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderMovementManager : MonoBehaviour
{
    //Ted

    public bool moveOnTime;

    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] public Transform movePoint;

    private void Start()
    {
      
    } 

    //gonna try to make a slightly worse enemy movement script than clara
    private void Update()
    {
        //will be called to cycle the movement direction
        for (int i = 0; i < 3; i++)
        {
            
        }
    }


    //will be called to move the invaders
    private void MoveInvadersRight()
    {

    }

    private void MoveInvadersLeft()
    {

    }

    private void MoveInvadersUp()
    {

    }

    private void MoveInvadersDown()
    {

    }
}
