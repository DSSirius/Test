using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void Update () {
		print ("Axis: " + CrossPlatformInputManager.GetAxis ("Horizontal"));
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (CrossPlatformInputManager.GetButtonDown ("Fire1")) {
			Debug.Log ("fire!");
		}
	}
}
