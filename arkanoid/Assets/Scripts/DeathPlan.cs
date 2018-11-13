using UnityEngine;


public class DeathPlan : MonoBehaviour
 {
     private void OnCollisionEnter2D(Collision2D other)
     {
         GameManager.instance.die();
     }
 }