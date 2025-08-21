using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed = 0.5f; // Speed of rotation
    public GameObject vfxOncollectEffect;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.Compurtag("Player"))
        {
            Instantiate(vfxOncollectEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
