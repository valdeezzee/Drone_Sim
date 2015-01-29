using UnityEngine;
using System.Collections;

public class DroneFlight : MonoBehaviour {


	private GameObject[] clockWisePropeller;
	private GameObject[] counterClockWisePropeller;
	private Transform[] propellerRotation;

	private float clockWiseRoation;
	private float counterClockWiseRotation;

	public NavMeshAgent agent;
	public GameObject target;
	public Vector3 targetPostion;
	// Use this for initialization
	void Start () 
	{

		targetPostion = target.transform.position;
		//gets the propellers
		clockWisePropeller = GameObject.FindGameObjectsWithTag("ClockwisePropeller");
		counterClockWisePropeller = GameObject.FindGameObjectsWithTag("CounterclockPropeller");
		//propeller rotation speeds
		clockWiseRoation = 20;
		counterClockWiseRotation = -20;
		agent = GetComponent<NavMeshAgent>();
		//agent.SetDestination(targetPostion);
	}
	
	// Update is called once per frame
	void Update () {

		//loops and rotates individual propeller
		for(int i = 0 ; i < clockWisePropeller.Length; i++)
		{
			clockWisePropeller[i].transform.Rotate(0, clockWiseRoation, 0, 0);
			counterClockWisePropeller[i].transform.Rotate(0, counterClockWiseRotation, 0, 0);
		}


		//Debug.Log(clockWiseRoation);


	}

	public void setDestination(Vector3 destination)
	{

		agent.SetDestination(destination);


	}


}
