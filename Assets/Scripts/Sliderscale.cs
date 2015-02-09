using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Sliderscale: MonoBehaviour {
	public Image FuelBar;
	public float DroneFuel;
	private float maxFuel = 1;
	// Use this for initialization
	void Start () {
		DroneFuel = maxFuel;
		FuelBar = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		FuelBar.fillAmount = DroneFuel;
		//FuelBar.transform.localScale 
	}
}