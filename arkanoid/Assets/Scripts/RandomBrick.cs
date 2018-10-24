using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBrick : MonoBehaviour {

    private int nextUpdate = 1;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }

    private void Update()
    {       
        if(Time.time >= nextUpdate)
        {      
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
        transform.position = newPos;
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
        } 
    }

}
