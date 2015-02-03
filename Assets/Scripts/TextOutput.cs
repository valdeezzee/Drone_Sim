using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextOutput : MonoBehaviour {
	
	//public Text
	public Canvas test;
	public GUIText test2;
	public Text elevation;
	private Vector3 down;
	public Transform obj;
	public Transform objtwo;
	public float distance;
	public float distance2;
	
	
	// Use this for initialization
	void Start () {
		elevation.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(obj.position, objtwo.position);
		distance2 = Mathf.Round (distance*100f)/100f; 
		elevation.text = distance2.ToString () + "FT";
	}
}
