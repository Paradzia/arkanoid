﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	public GameObject bricksPrefab;
	public GameObject paddle;
	private GameObject clonePaddle;
    public GameObject randomBrick;
    public static GameManager instance = null;

    public int lossCounter=1;

    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float fallingSpeed;
    public List <GameObject> objectList;
    private Boolean generateObjects = true;


    void Start () {
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(gameObject);
		}

        setup();
        StartCoroutine(SpawnWaves());   
    }

public static GameManager getInstance(){
    return instance;
}
        IEnumerator SpawnWaves()
        {
            yield return new WaitForSeconds(startWait);
            while (generateObjects)
            {
                Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range((float)-1.5, (float)3.2), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                objectList.Add(Instantiate(randomBrick, spawnPosition, spawnRotation)); 
                yield return new WaitForSeconds(waveWait);
            }
        }
    

    public void destroyObjects(){     
        lossCounter++; 
        Debug.Log(lossCounter); 
        foreach(var obj in objectList){  
            Destroy(obj, 0.01f);
        }
    }
    public void setup()
	{
        objectList = new List<GameObject>();
		clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
	}

    public void createNewPaddle(){
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

    public void destroyPaddle(){
        Destroy(clonePaddle);
    }

    public void objectGeneratorSwitch(){
        generateObjects = !generateObjects;
    }

}
