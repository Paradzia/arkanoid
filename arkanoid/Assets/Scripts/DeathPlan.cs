using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlan : MonoBehaviour {
	private void OnTriggerEnter2D(Collider2D collider)
	{
		GameManager.instance.die();
	}
}
