using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.instance.destroyBrick();
        Destroy(gameObject);
    }
}