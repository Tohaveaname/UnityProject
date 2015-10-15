using UnityEngine;
using System.Collections;

public class StartDisabled : MonoBehaviour {

	//Starts the object as not active.
	void Start ()
    {
        gameObject.SetActive(false);
	}
}
