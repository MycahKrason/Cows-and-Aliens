﻿using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {

	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	
	void OnMouseDown(){
		levelManager.AdsLoadlevel("LoseScreen");
	}
}
