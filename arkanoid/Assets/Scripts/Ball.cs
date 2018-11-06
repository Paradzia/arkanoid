using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

	public float ballInitialVelocity = 600f;

	private Rigidbody2D rb;
	private bool ballInPlay;
	private Vector3 ballPosition;
	private Vector3 playerPos = new Vector3(0f, -3.5f, 0);

	void Awake()
	{
		transform.position = playerPos;
		rb = GetComponent<Rigidbody2D>();
	}
	
	
	void Update () {
		if (Input.GetButtonDown("Fire1") && ballInPlay == false)
		{
			transform.parent = null;
			ballInPlay = true;
			rb.isKinematic = false;
			rb.AddForce(new Vector2(ballInitialVelocity, ballInitialVelocity));
		}
	}
}
