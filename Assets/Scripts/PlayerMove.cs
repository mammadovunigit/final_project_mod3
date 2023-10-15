using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float forwardspeed = 5.0f;
    private float horizontalspeed = 4;
    private float horizontalInput;
    private float leftBoundary = -3.4f;
    private float rightBoundary = 3.83f;
    private float speedIncrease = 2.0f;
    public float speedIncreaseInterval = 10.0f;
    public float timer = 0.0f;
    


   
    void Start()
    {
       
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        // Update the timer
        timer += Time.deltaTime;

        if (timer >= speedIncreaseInterval)
        {
            // Increase the speed
            forwardspeed += speedIncrease;
            timer = 0.0f; // Reset the tier
        }

        
        transform.Translate(Vector3.forward * Time.deltaTime * forwardspeed);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * horizontalspeed );

        // New position based on input and speed
        Vector3 newPosition = transform.position +
            (Vector3.forward * Time.deltaTime * forwardspeed) +
            (Vector3.right * horizontalInput * Time.deltaTime * horizontalspeed );

        // Clamp the new position to stay within the boundaries
        newPosition.x = Mathf.Clamp(newPosition.x, leftBoundary, rightBoundary);

        transform.position = newPosition; //update position
    }

}

