using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sliderscale: MonoBehaviour {

	public GameObject Drone;
	public Drone_Stats status;
	public Image FuelBar;

	public float DroneFuel;
	private float maxFuel = 1;
	private float barX  = 0.0f;
	private float barY = 0.0f;


	// Use this for initialization
	void Start () {
		DroneFuel = maxFuel;

		status = Drone.GetComponent<Drone_Stats>();
		FuelBar = GetComponent<Image>();

		barX = FuelBar.transform.localScale.x;
		barY = FuelBar.rectTransform.localScale.y;


	}
	
	// Update is called once per frame
	void Update () {
		FuelBar.fillAmount = DroneFuel;

		FuelBar.transform.localScale = new Vector3(barX, barY, 1);

		barX = status.getFuel() * .011f;
		/*
		if (Input.GetKeyDown("h"))
		{
			//print ("hello");
			barX = barX + .011f;


		}
		*/


	}
}