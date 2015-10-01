using UnityEngine;
using System.Collections;

public class BlackBackgroundScript : MonoBehaviour {

    public BookMaster bookMaster;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(bookMaster.currentPage != 1)
        {
            gameObject.SetActive(false);
        }
	}
}
