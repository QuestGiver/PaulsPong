using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Transform ball;
    public float speed;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(0, 0, 8.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.x > transform.position.x)
        {
            Debug.Log("up");
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if (ball.position.x < transform.position.x)
        {
            Debug.Log("down");
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }

        if (transform.position.x > -3.9f)
        {
            transform.position.Set(-3.9f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < 3.9f)
        {
            transform.position.Set(3.9f, transform.position.y, transform.position.z);
        }


        Mathf.Clamp(transform.position.x, -3.9f, 3.9f);
    }
}
