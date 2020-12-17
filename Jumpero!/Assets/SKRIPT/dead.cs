﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void Reset()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
