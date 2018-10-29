using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vive_Manager : MonoBehaviour {

	public GameObject head; 
	public GameObject leftHand; 
	public GameObject rightHand; 

	public static Vive_Manager Instance; 

	void Awake(){
		if (Instance == null) {
			Instance = this; 
		}
	}

	void OnDestroy(){
		if (Instance == this) {
			Instance = null; 
		}
	}
}
