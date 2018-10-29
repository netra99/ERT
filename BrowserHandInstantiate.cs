using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR; 

public class BrowserHandInstantiate : MonoBehaviour {
    [SerializeField]
    private int count = 0; 
    private Transform rig;
    public GameObject laser;  
    private Valve.VR.EVRButtonId touchpad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device controller
    {
        get
        {
            return SteamVR_Controller.Input((int)trackedObj.index);
        }
    }

    private Vector2 axis = Vector2.zero;

    // Use this for initialization
    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
        laser.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }

        var device = SteamVR_Controller.Input((int)trackedObj.index);

        if (controller.GetTouch(touchpad))
        {
            if ((count % 2) == 0)
            {
                laser.SetActive(true);
                Debug.Log("on");
            }
            else
            {
                Debug.Log("off"); 
                laser.SetActive(false); 
            } 
        }
        count += 1;

    }
}
