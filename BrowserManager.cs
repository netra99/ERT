using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrowserManager : MonoBehaviour {

    public ZenFulcrum.EmbeddedBrowser.Browser dataBrowser;
    //public ScreenSlideShow dataSlides; 

    public void PostPageOnBrowser(string site)
    {
        if(dataBrowser!= null)
        {
            dataBrowser.gameObject.SetActive(true);
            dataBrowser.LoadURL(site, true); 
        }
    }

    /*public void JumpToSlideOnSlideShow(int slide)
    {
        if(dataSlides != null)
        {
            dataSlides.gameObject.SetActive(true);
            dataSlides.GoTo(slide); 
        }
    }*/
    public void DisableBrowser()
    {
        if(dataBrowser != null)
        {
            dataBrowser.gameObject.SetActive(false); 
        }
    }
}
