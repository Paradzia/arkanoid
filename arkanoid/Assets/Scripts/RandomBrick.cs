using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBrick : MonoBehaviour
{

    public GameObject brickParticle;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.ToString().StartsWith("square"))
        {
            GameManager.instance.die();
        }
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        GameManager.instance.score++;
        Destroy(gameObject);    
    }

    private void Update()
    {       
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y - GameManager.instance.fallingSpeed, transform.position.z);
            transform.position = newPos;         
    }

}
