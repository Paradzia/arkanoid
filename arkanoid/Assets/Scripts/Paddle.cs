using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

	public float paddleSpeed = 1f;
	
	private Vector3 playerPos = new Vector3(0f, -0.2f, 0);

    private void Start()
    {
        transform.position = new Vector3(Mathf.Clamp(0, -1.47f, 1.43f), -4.5f, 0f);
    }

    void Update ()
	{
        if(Input.touchCount > 0) {
           // float xTouchPos = transform.position.x + Input.GetAxis("Horizontal") * paddleSpeed;
            float xTouchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).x;
            playerPos = new Vector3(Mathf.Clamp(xTouchPos, -1.47f, 1.43f), -4.5f, 0f);	
		    transform.position = playerPos;
        }   
        
    }

    public void upgradePaddle()
    {
        transform.localScale = new Vector3(transform.localScale.x + 0.5f, transform.localScale.y, transform.localScale.z);
    }


}
