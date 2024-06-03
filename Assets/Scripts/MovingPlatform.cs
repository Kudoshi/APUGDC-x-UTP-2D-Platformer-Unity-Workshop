using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float MoveSpeed;
    public Transform FirstPoint;
    public Transform SecondPoint;


    private Vector3 CurrentToPosition; // 1 for first position 2 for second position
    private Vector3 FirstPosition;
    private Vector3 SecondPosition;

    private void Start()
    {
        // Copy over the position of First and Second point
        FirstPosition = FirstPoint.position;
        SecondPosition = SecondPoint.position;
        CurrentToPosition = FirstPosition;

    }
    private void Update()
    {
        // Check if reach point. If yes then move to the next position
        if (transform.position == FirstPosition)
        {
            CurrentToPosition = SecondPosition;
        }
        else if (transform.position == SecondPosition)
        {
            CurrentToPosition = FirstPosition;
        }


        // Move obstacle to the position
        transform.position = Vector3.MoveTowards(transform.position, CurrentToPosition, MoveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }

}
