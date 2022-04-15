using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    private float speed = 20;
    private Vector3 v = new Vector3(1, 0, 0);
    public float hip;
    // Start is called before the first frame update
    public GameObject yuzhiti;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hip = Input.GetAxis("Horizontal");

        if (transform.position.x < -20)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 20)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }

        transform.Translate(v * speed * Time.deltaTime * hip);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(yuzhiti, transform.position, yuzhiti.transform.rotation);
        }


    }
}
