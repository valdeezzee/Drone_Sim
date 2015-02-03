using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextOutput : MonoBehaviour {

	//public Text
	public Canvas test;
	public GUIText test2;
	public Text elevation;
	private Vector3 down;
	
	// Use this for initialization
	void Start () {
		elevation.text = "10";
	}
	
	// Update is called once per frame
	void Update () {

	}
}
