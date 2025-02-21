using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SushiSpawner : MonoBehaviour
{
    public GameObject SushiPrefabs;
    public transform spawnPos;
    public button spawn;

    public float b = 12f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnSushi()
    {
        instantiate(SushiPrefabs, spawnPos, 0);

    }
}
