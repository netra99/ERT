using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : Photon.MonoBehaviour {

    public int index = 1; 

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (photonView.isMine) {
            switch (index)
            {
                case 1:
                    transform.position = Vive_Manager.Instance.head.transform.position;
                    transform.rotation = Vive_Manager.Instance.head.transform.rotation;
                    break;
                case 2:
                    transform.position = Vive_Manager.Instance.leftHand.transform.position;
                    transform.rotation = Vive_Manager.Instance.leftHand.transform.rotation;
                    break;
                case 3:
                    transform.position = Vive_Manager.Instance.rightHand.transform.position;
                    transform.rotation = Vive_Manager.Instance.rightHand.transform.rotation;
                    break; 
            }

            
		}
	}
}
