using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesdroyItem : MonoBehaviour
{
    private float topB = 30;
    private float lowerB = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topB)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerB)
        {
            
            Destroy(gameObject);
            Debug.Log("Game Over!!!");
        }
    }
}
