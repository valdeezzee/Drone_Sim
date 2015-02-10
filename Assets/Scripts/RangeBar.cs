using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RangeBar : MonoBehaviour {

	public GameObject Drone;
	public Drone_Stats status;
	public Image R_Bar;
	
	public float DroneFuel;
	private float maxFuel = 1;
	
	private float rangeX  = 0.0f;
	private float rangeY = 0.0f;
	
	// Use this for initialization
	void Start () {
		DroneFuel = maxFuel;

		status = Drone.GetComponent<Drone_Stats>();
		R_Bar = GetComponent<Image>();
		
		rangeX = R_Bar.transform.localScale.x;
		rangeY = R_Bar.rectTransform.localScale.y;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		R_Bar.fillAmount = DroneFuel;

		
		R_Bar.transform.localScale = new Vector3(rangeX, rangeY, 1);

		rangeX = status.getRange() * .011f;
		/*
		if (Input.GetKeyDown("j"))
		{
			//print ("hello");
			rangeX = rangeX + .011f;
			
			
		}
		*/
		
		
	}
}
