using UnityEngine;
using System.Collections;

public class Drone_Stats : MonoBehaviour {

	private float fuel = 100.0f;
	private float health = 100.0f;
	private float range = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown("h"))
		{
			//print ("hello");
			fuel -= 1;
			print("LosingFuel");
			
		}

		if (Input.GetKeyDown("j"))
		{
			//print ("hello");
			health -= 1;
			print("TakingDamage");
			
		}

		if (Input.GetKeyDown("k"))
		{
			//print ("hello");
			range -= 1;
			print("Range");
			
		}

	}

	public float getFuel()
	{
		return 100 - fuel;
	}

	public float getHeatlh()
	{

		return 100 - health;
	}

	public float getRange()
	{
		return 100 - range;

	}

}
