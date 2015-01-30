using UnityEngine;
using System.Collections;

public class PossessDrone : MonoBehaviour {

	public GameObject Drone;
	public DroneFlight droneDestination;
	public GameObject miniMap;
	public Fly_To newDrone;
	// Use this for initialization
	void Start () {
		//gets the drone GameObject and gets the DroneFlight script
		Drone = GameObject.Find("Drone");
		droneDestination = Drone.GetComponent<DroneFlight>();
		miniMap = GameObject.Find("MiniMap");
		newDrone = miniMap.GetComponent<Fly_To>();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButtonDown(0))
		{	/*
			if (Input.GetButtonDown("Fire1") && Camera.main.pixelRect.Contains(Input.mousePosition))

           */
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray, out hit))
			{ 		
				 //if(hit.transform.gameObject.tag == "Building"){
					

					// use this to get the parent of the camera you click on and posses that drone!
					Drone = this.transform.parent.gameObject;
					newDrone.dronePossessed(Drone);
				    print ("CLICKed");
				    print(camera.transform.position + "HERE");
					//this to be the drone destination 
					//Sends the position you want to send your drone to
					//print(hit.transform.position);
					//droneDestination.setDestination(hit.transform.position);
				//}
			}
		}
	}
}
