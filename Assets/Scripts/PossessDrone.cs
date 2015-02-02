using UnityEngine;
using System.Collections;

public class PossessDrone : MonoBehaviour {

	public GameObject Drone;
	public GameObject DroneGuide;
	public DroneFlight droneDestination;
	public GameObject miniMap;
	public Fly_To newDrone;
	// Use this for initialization
	void Start () {
		//gets the drone GameObject and gets the DroneFlight script
		Drone = GameObject.Find("DroneGuide");
		droneDestination = Drone.GetComponent<DroneFlight>();
		miniMap = GameObject.Find("MiniMap");
		newDrone = miniMap.GetComponent<Fly_To>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0))
		{	
		




			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray, out hit))
			{ 		
				 //if(hit.transform.gameObject.tag == "Building"){
					

					// use this to get the parent of the camera you click on and posses that drone!
					Drone = this.transform.parent.gameObject;
					DroneGuide = Drone.transform.parent.gameObject;
				    print(DroneGuide.gameObject.tag);
					print (camera.gameObject.tag);
					//newDrone.dronePossessed(Drone);
				    //print ("CLICKed");
				    //print(camera.transform.position + "HERE");
				    newDrone.dronePossessed(DroneGuide);
					//this to be the drone destination 
					//Sends the position you want to send your drone to
					//print(hit.transform.position);
					//droneDestination.setDestination(hit.transform.position);
				//}
			}
		} 
	}
}
