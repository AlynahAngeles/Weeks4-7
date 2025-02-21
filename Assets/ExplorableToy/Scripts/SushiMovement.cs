using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiMovement : MonoBehaviour //Initiate public class for moving the sushi across the screen
{

    public float speed = 2f; //Set float speed to 2 (sushi default speed is 2)
    private float destroyTimer = 0f; //Set a private float for the timer that will destroy sushi gameObjects, set this timer to 0
    private float destroyDelay = 5f; //Set a float for the delay of the destroy, make the value 5 to destroy the object in 5 seconds
    private bool edge = false; //Create a boolean and set it to false, this detects whether the GameObject is at the edge of the screen or not

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!edge) //If GameObject not at the edge...
        {
            transform.position += Vector3.right * speed * Time.deltaTime; //Transform the position moving to the right using the speed of the slider

            Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position); //Lock the object;s positioning to the game camera, ensures consistent movement despite screen ratios

            if (screenPos.x >= Screen.width) //If the sushi positioning in greater than or equal to the screen width, execute the following code...
            {
                edge = true; //Change the boolean value to true
            }
        }
        else //If the Object is at the edge of the screen, execute this code...
        {
            destroyTimer += Time.deltaTime; //Start the timer from 0 and update based on time

            if (destroyTimer >= destroyDelay) //If the destroyTimer (0) is greater than or equal to the delay (5)
            {
                Destroy(gameObject); //Destroy the GameObject
            }
        }
    }
}
