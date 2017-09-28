using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{
	static MusicPlayer instance = null;

	// Use this for initialization
	void Start ()
	{
		if (instance != null) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}

	}

	// Update is called once per frame
	void Update ()
	{

	}
}
//music is being played a frame late. SHould be on void update. ran per second 

