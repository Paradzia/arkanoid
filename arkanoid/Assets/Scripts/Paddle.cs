using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

	public float paddleSpeed = 1f;
	
	private Vector3 playerPos = new Vector3(0f, -0.2f, 0);
	
	void Update ()
	{
		//		float xPos = transform.position.x + Input.GetAxis("Horizontal") * paddleSpeed;
//		TODO: test on device if this thingy works. 
		float xPos = transform.position.x + Input.GetTouch(0).position.x * paddleSpeed;
		xPos = xPos/100-2;
		Debug.Log(xPos + "  " + xPos);
		playerPos = new Vector3(Mathf.Clamp(xPos, -1.47f, 1.43f), -4.5f, 0f);
		transform.position = playerPos;
	}

	
}
