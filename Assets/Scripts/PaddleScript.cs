using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float speed;


    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(0, 0, -8.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.x >= -3.8f)
        {
            transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) && transform.position.x <= 3.8f)
        {
            transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }

        Mathf.Clamp(transform.position.x, -3.8f, 3.8f);


    }
}
