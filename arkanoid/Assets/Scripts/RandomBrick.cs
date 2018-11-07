using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBrick : MonoBehaviour
{

    public GameObject brickParticle;
    private int _nextUpdate = 1;    
    private void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        GameManager.instance.score++;
        Destroy(gameObject);    
    }

    private void Update()
    {       
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y - GameManager.instance.fallingSpeed, transform.position.z);
            transform.position = newPos;
            _nextUpdate = Mathf.FloorToInt(Time.time) + 1;               
    }

}
