using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject[] sA = new GameObject[3];
    private float randomX = 20;
    private float randomZ = 20;
    private float startTime = 2;
    private float dl = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnA", startTime, dl);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnA()
    {
        int animal = Random.Range(0, sA.Length);

        float rP = Random.Range(-randomX, randomX);
        Vector3 randomP = new Vector3(rP, 0, 25);

        Instantiate(sA[animal], randomP, sA[animal].transform.rotation);
    }
}
