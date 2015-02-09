using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test : MonoBehaviour {

	public GameObject UAV;
	public RectTransform knob;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newLocation = new Vector3(180,0,UAV.transform.eulerAngles.y);
		knob.rotation = Quaternion.Euler (newLocation);
		print (knob.transform.eulerAngles.z);

	}
}
