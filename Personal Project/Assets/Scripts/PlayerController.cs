using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 1000.0f;
    private float forwardInput;
    private float horizontalInput;
    private float xRange = 65f;
    private float zRange = 65f;
    public ParticleSystem watersplatterParticle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player Movement
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        //  Player Bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

      if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

         if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plastic"))
        {
            Destroy(other.gameObject);
        }

    }

    private void OnTriggerEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Companion"))
        {
            Rigidbody companionRb = collision.gameObject.GetComponent<Rigidbody>();
        }
    }
}