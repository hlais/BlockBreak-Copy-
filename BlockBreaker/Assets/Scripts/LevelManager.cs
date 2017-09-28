using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name) {

		Debug.Log ("Level Loas Requested");
		brick.breakableCount = 0;
		Application.LoadLevel (name);
	}
	public void QuitLevel ()
	{
		Debug.Log ("Game has quit");
		Application.Quit ();
	}

	public void LoadNextLevel()
	{
		brick.breakableCount = 0;
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void BrickDestroyed ()
	{
		if (brick.breakableCount <= 0)//last brick destroyed)
		{
			LoadNextLevel ();
		}
	}


}
