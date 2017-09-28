using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;

	private Ball ball;
	public float min;
	public float max;

	void Start ()
	{
		ball = GameObject.FindObjectOfType<Ball> ();// this finds the ball in the scene
		print (ball);
	}


	void Update () {
		if (!autoPlay) {

			MoveWithMouse ();
		} else {

			AutoPlay ();
		}
	}
	void AutoPlay ()
	{

		Vector3 paddlePos = new Vector3 (0.5f, 0.5f, 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp (ballPos.x, min, max);
		this.transform.position = paddlePos;
		
	}
	void MoveWithMouse ()
	{ 
	Vector3 paddlePos = new Vector3 (0.5f, 0.5f, 0f);
	float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

	paddlePos.x = Mathf.Clamp (mousePosInBlocks, min, max);//we are only moving the x position via mouse 

			this.transform.position = paddlePos;
	}
}
