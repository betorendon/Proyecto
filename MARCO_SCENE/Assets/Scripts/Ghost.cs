﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    public AudioSource ghostSource;
    // Start is called before the first frame update
    void Start()
    {
        ghostSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.tag == "Player") {
            ghostSource.Play();
        }
        print("Collided");
    }
}
