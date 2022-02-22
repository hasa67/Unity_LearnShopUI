using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	void Awake(){
		print ("awake");
	}

	// Use this for initialization
	void Start () {
		print ("start");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnEnable(){
		print ("enabled");
	}

	void OnDisable(){
		print ("disabled");
	}
}
