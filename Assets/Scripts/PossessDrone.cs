using UnityEngine;
using System.Collections;

public class PossessDrone : MonoBehaviour {

	public GameObject Drone;
	public DroneFlight droneDestination;
	// Use this for initialization
	void Start () {
		//gets the drone GameObject and gets the DroneFlight script
		Drone = GameObject.Find("Drone");
		droneDestination = Drone.GetComponent<DroneFlight>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray, out hit))
			{
				if(hit.transform.gameObject.tag == "Building")
				{
					print (camera.transform.position + "HERE");
					/*
					use this to get the parent of the camera you click on and posses that drone!
					Drone = this.transform.parent.gameObject;
					*/
					//this to be the drone destination 
					//Sends the position you want to send your drone to
					print(hit.transform.position);
					droneDestination.setDestination(hit.transform.position);
				}
			}
		}
	}
}
