﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2.5f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // spawn obstacle
    void SpawnObstacle ()
    {
        if (playerControllerScript.gameOver == false) // if game is still running keep spawning obstacle
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

    }
}
