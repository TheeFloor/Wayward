using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pollution : MonoBehaviour
{
    public float speed;
    private Rigidbody pollutionRb;
    private GameObject player;
    public int plasticCount;
    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        pollutionRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized; 

        pollutionRb.AddForce(lookDirection * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!gameObject.CompareTag("Pollution")) { gameManager.GameOver(); }
    }
}

