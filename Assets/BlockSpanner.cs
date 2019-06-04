﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpanner : MonoBehaviour
{
	public Transform[] spawnPoints;
	public GameObject blockPrefab;
	private float timeBetweenWaves=1f;
	private float timeToSpawn=2f;
    // Start is called before the first frame update
    void SpawnBlocks()
    {
      int randomIndex=Random.Range(0,spawnPoints.Length);
      for(int i=0;i<spawnPoints.Length;i++){
      	if(randomIndex !=i){
      		Instantiate(blockPrefab,spawnPoints[i].position,Quaternion.identity);
      	}
      }  
    }

    // Update is called once per frame
    void Update()
    {
    	if(Time.time >= timeToSpawn){
        SpawnBlocks();
        timeToSpawn=Time.time + timeBetweenWaves;
    }
    }
}
