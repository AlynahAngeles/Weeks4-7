using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiEat : MonoBehaviour //initiate class for eating sushi prefabs!
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown() //When the mouse is down (using a 2D collider)...
    {
        Destroy(gameObject); //Destroy the gameObject
    }
}
