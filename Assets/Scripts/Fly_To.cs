using UnityEngine;
using System.Collections;

public class Fly_To : MonoBehaviour {

	public GameObject Drone;
	public DroneFlight droneDestination;



 
	// Use this for initialization
	void Start () {
		//gets the drone GameObject and gets the DroneFlight script
		Drone = GameObject.Find("DroneGuide");
		droneDestination = Drone.GetComponent<DroneFlight>();

	}
	
	// Update is called once per frame
	void Update () {


	
		if(Input.GetMouseButtonDown(0) && camera.pixelRect.Contains(Input.mousePosition))
		{
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray, out hit))
			{
				if(hit.transform.gameObject.tag == "Building")
				{
				print("new drone");
				//print (camera.transform.position + "HERE");
				//this to be the drone destination 
				//Sends the position you want to send your drone to
				//print(hit.transform.position);
				droneDestination.setDestination(hit.transform.position);
				}
			}
		}


	}

	public void dronePossessed(GameObject newDrone)
	{

		Drone = newDrone;
		droneDestination = Drone.GetComponent<DroneFlight>();
		print(Drone.gameObject.tag + "!");


	}
}
