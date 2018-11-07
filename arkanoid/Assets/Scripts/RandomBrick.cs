using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBrick : MonoBehaviour {

    private int nextUpdate = 1;
    private int nextSpeedUp = 20;
    //public float fallingSpeed = 0.2f;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);    
    }

    private void Update()
    {       
        if(Time.time >= nextUpdate)
        {      
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y - GameManager.instance.fallingSpeed, transform.position.z);
            transform.position = newPos;
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;           
        } 
        if(Time.time >= nextSpeedUp)
        {
            GameManager.instance.fallingSpeed += 0.01f;
            nextSpeedUp = Mathf.FloorToInt(Time.time) + 10;
        }
    }

}
