using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canv : MonoBehaviour {

	public GameObject can;
	// Use this for initialization
	void Start () {
		can.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ca()
    {
		can.SetActive(true);
		Debug.Log("OK");
    }
}
