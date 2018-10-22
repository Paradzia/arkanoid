using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("predupa");
        GameManager.instance.destroyBrick();
        Destroy(gameObject);
        Debug.Log("dupa");
    }
}