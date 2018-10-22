using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	public int bricks = 20;
	public GameObject bricksPrefab;
	public GameObject paddle;
	private GameObject clonePaddle;
	public static GameManager instance = null;

	
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
	}

	public void setup()
	{
		clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
		Instantiate(bricksPrefab, transform.position, Quaternion.identity);
	}

	public void destroyBrick()
	{
		bricks--;
	}
	
}
