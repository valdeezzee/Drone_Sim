using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	public GameObject Drone;
	public Drone_Stats status;
	public Image H_Bar;
	
	public float DroneFuel;
	private float maxFuel = 1;

	private float healthX  = 0.0f;
	private float healthY = 0.0f;
	
	// Use this for initialization
	void Start () {
		DroneFuel = maxFuel;

		status = Drone.GetComponent<Drone_Stats>();
		H_Bar = GetComponent<Image>();
		
		healthX = H_Bar.transform.localScale.x;
		healthY = H_Bar.rectTransform.localScale.y;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		H_Bar.fillAmount = DroneFuel;

		
		H_Bar.transform.localScale = new Vector3(healthX, healthY, 1);

		healthX = status.getHeatlh() * .011f;
		/*
		if (Input.GetKeyDown("g"))
		{
			//print ("hello");
			healthX = healthX + .011f;
			
			
		}
		*/
		
		
	}
}
