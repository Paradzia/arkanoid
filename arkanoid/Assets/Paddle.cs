using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

	public float paddleSpeed = 1f;
	
	private Vector3 playerPos = new Vector3(-1.25f, -4.5f, 0);
	
	void Update ()
	{
		float xPos = transform.position.x + Input.GetAxis("Horizontal") * paddleSpeed;
		playerPos = new Vector3(Mathf.Clamp(xPos, -2f, 1.4f), -4.5f, 0f);
		transform.position = playerPos;
	}
}
