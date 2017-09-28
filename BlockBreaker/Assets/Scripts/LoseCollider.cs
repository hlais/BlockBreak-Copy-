using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour
{
	private LevelManager levelManager;

	void OnTriggerEnter2D (Collider2D trigger)
	{
		levelManager = GameObject.FindObjectOfType<LevelManager> (); // this code basically looks for the level manager on the unity editor 
		levelManager.LoadLevel ("Lose Screen");
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		Debug.Log("Collision");
	}
}
