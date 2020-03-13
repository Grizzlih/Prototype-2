﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
	public GameObject[] animalPrefabs;
	private float spawnRangeX = 20;
	private float spawnRangeZ = 20;
	private float startDelay = 2;
	private float spawnInterval = 2.0f;

	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void SpawnRandomAnimal()
	{
		int animalIndex = Random.Range(0, animalPrefabs.Length);
		Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeZ), 0, spawnRangeZ);
		Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
	}
}
