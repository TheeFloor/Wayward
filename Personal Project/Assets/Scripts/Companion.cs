using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Companion : MonoBehaviour
{
    public float speed;
    private Rigidbody companionRb;
    private GameObject player;
    private GameObject companion;
    public GameObject plasticIndicator;
    
   
    // Start is called before the first frame update
    void Start()
    {
        companionRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        companion = GameObject.Find("Companion");
    }

    // Update is called once per frame
    void Update()
    {
        // companion follows the player
        Vector3 lookDirection = (player.transform.position - transform.position).normalized; 

       companionRb.AddForce(lookDirection * speed);

       plasticIndicator.transform.position = transform.position + companion.transform.position;
    }
}
