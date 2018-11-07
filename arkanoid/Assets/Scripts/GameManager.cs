using System;
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

    private int lossCounter=0;

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
                Debug.Log("generator");
                for (int i = 0; i < hazardCount; i++)
                {
                    Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                    Quaternion spawnRotation = Quaternion.identity;
                    objectList.Add(Instantiate(randomBrick, spawnPosition, spawnRotation)); 
                    yield return new WaitForSeconds(spawnWait);
                }
                yield return new WaitForSeconds(waveWait);
            }
        }
    

    public void destroyObjects(){
        objectGeneratorSwitch();        
        foreach(var obj in objectList){  
            Destroy(obj, 0.01f);
        }
    }
    public void setup()
	{
        objectList = new List<GameObject>();
		clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
	}

    public void qwe(){
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

    public void objectGeneratorSwitch(){
        generateObjects = !generateObjects;
    }

}
