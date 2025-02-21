using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SushiSpawner : MonoBehaviour
{
    public GameObject SushiPrefabs;
    public Transform spawnPos;
    //public Button spawn;

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
        Instantiate(SushiPrefabs, spawnPos);

    }
}
