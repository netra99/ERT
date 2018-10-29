using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;
public class BoardSynchronize : MonoBehaviour {
   
    public ZenFulcrum.EmbeddedBrowser.Browser teacherbrowser;
    private string teacherUrl;
    private string mainUrl;



    // Use this for initialization
    void Start () {
        if (teacherbrowser == null) return;
        Browser teacherScript = teacherbrowser.GetComponent<Browser>();
        Browser mainScript = GetComponent<Browser>(); 
        teacherUrl = teacherScript.Url;
        mainUrl = mainScript.Url; 
	}
	
	// Update is called once per frame
	void Update () {
        Browser mainScript = GetComponent<Browser>();
        //Debug.Log("URL: " + mainScript.Url); 
        if (teacherUrl != mainUrl)
        {
            //Debug.Log("reached mismatch"); 
            mainScript.LoadURL(teacherUrl, true);
            mainUrl = teacherUrl; 
        }
        if (teacherbrowser == null) return;
        Browser teacherScript = teacherbrowser.GetComponent<Browser>();
        teacherUrl = teacherScript.Url; 
	}
}
