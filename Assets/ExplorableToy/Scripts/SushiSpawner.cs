using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SushiSpawner : MonoBehaviour //Initiate public class under name "SushiSpawner"
{
    public GameObject[] SushiPrefabs; //State array for sushi prefabs under name "SushiPrefabs"
    public Transform spawnPos; //State transform variable called spawnPos for sushi spawn position
    public float speed = 2f; //State public float for sushi speed when coming out of machine, set value to 2

    public Slider speedSlider; //Create public slider variable to adjust the speed of the conveyor

    // Start is called before the first frame update
    void Start()
    {
        if (speedSlider != null) //If the object is initialized, execute the following code...
        {
            speedSlider.value = speed; //Get the value of the speedSlider and equalize the value of the slider to teh speed of the object
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (speedSlider != null) //If the speedSlider object is initialized, execute the following code...
        {
            speed = speedSlider.value; //Set the speed to the value of the slider
        }
    }

    public void spawnSushi() //Create a function for spawning in the sushi!
    {
        GameObject newSushi = Instantiate(SushiPrefabs[Random.Range(0, SushiPrefabs.Length)], spawnPos); //When function is called, instantiate a new sushi prefab from the array (randomize the prefabs at the spawn position.

        SushiMovement sushiMovement = newSushi.GetComponent<SushiMovement>(); //When the sushi is spawned, get the component SushiMovement and update the sushi's position based on the component's code
        if (sushiMovement != null) //If sushiMovement is initialized...
        {
            sushiMovement.speed = speed; //Call the sushi speed function and move the sushi based on the speed value (makes the sushi move according to the value of the slider)
        }
    }
}
