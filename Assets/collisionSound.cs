using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionSound : MonoBehaviour
{
     AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Debug-draw all contact points and normals
        Debug.Log("collision detected \n");
        Debug.Log(collision.gameObject.name);

        
        audioSource.Play();
    }
}
