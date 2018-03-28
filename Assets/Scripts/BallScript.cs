using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int RedScore = 0;
    public int BlueScore = 0;
    public float ballSpeedMultiplier;
    public float startSpeed = 1000;
    public Rigidbody rb;
    public bool bound = false;
    

    // Use this for initialization
    void Start()
    {
        rb.AddForce(new Vector3(Random.Range(startSpeed, -startSpeed), 0, Random.Range(startSpeed, -startSpeed)).normalized * startSpeed * Time.deltaTime, ForceMode.VelocityChange);
        BlueScore = 0;
        RedScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Physics.Raycast(transform.position, new Vector3(0, -1, 0)))
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(rb.velocity.magnitude);
        rb.velocity *= ballSpeedMultiplier;//new Vector3(rb.velocity.x * ballSpeedMultiplier, rb.velocity.y * ballSpeedMultiplier, rb.velocity.z * ballSpeedMultiplier);


        if (collision.rigidbody != null)
        {
            if (collision.rigidbody.tag == "RedBrick")
            {
                BlueScore++;
                transform.position = new Vector3(0, 0, 0);
                rb.velocity *= 0;
                rb.AddForce(new Vector3(Random.Range(startSpeed, -startSpeed), 0, Random.Range(startSpeed, -startSpeed)).normalized * startSpeed * Time.deltaTime, ForceMode.VelocityChange);

            }
            if (collision.rigidbody.tag == "BlueBrick")
            {
                RedScore++;
                transform.position = new Vector3(0, 0, 0);
                rb.velocity *= 0;
                rb.AddForce(new Vector3(Random.Range(startSpeed, -startSpeed), 0, Random.Range(startSpeed, -startSpeed)).normalized * startSpeed * Time.deltaTime, ForceMode.VelocityChange);
            }
        }
    }


}
