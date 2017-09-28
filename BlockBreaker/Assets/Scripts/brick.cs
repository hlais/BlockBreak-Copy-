using UnityEngine;
using System.Collections;


public class brick : MonoBehaviour {

	public AudioClip crack;
	public static int breakableCount = 0;
	private LevelManager levelManager;
	private bool isBreakable; 


	public Sprite [] hitSpirte;
	private int timesHit;



	// Use this for initialization
	void Start () {
		isBreakable =  (this.tag == "Breakable");
		//we are keeping track of breakable bricks here



		 //we tagged Breakable via unity inspector 
		if (isBreakable) 
		{
			breakableCount++;

		}

		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		timesHit = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

	
	
	}
	void OnCollisionEnter2D (Collision2D col)
	{
		AudioSource.PlayClipAtPoint (crack, transform.position, 0.8f);
		if (isBreakable) 
		{
			HandleHIts ();


		}




	}

	void HandleHIts ()
	{
		timesHit++;

		int maxHits = hitSpirte.Length + 1;  //array length plus one is equal to the max before the brick breaks. 
		if (timesHit >= maxHits) {
			breakableCount--; // we decrease the object just beofre we destroy the object
			Debug.Log (breakableCount);
			levelManager.BrickDestroyed ();
			Destroy (gameObject);
		} else {
			LoadSprites ();
		}
		
	}

	void LoadSprites()
	{
		int spriteIndex = timesHit - 1;
		if (hitSpirte [spriteIndex]) // checking if we even have a hit sprite 
		{
			this.GetComponent<SpriteRenderer> ().sprite = hitSpirte [spriteIndex];
		}

	}


	void SimulateWin ()
	{

		levelManager.LoadNextLevel();
	}
}
