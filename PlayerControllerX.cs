using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame

    void Start()
    {
        //InvokeRepeating("SpawnDog", 1, 3);
    }
    void Update()
    {
        // On spacebar press, send dog
        InvokeRepeating("SpawnDog", 1, 3);

    }

    void SpawnDog()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
