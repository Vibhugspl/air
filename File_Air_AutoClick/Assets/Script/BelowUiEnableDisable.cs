using UnityEngine;
using System.Collections;

public class BelowUiEnableDisable : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);

		transform.position = Camera.main.transform.position + Camera.main.transform.forward * 0.05f;
		transform.position = new Vector3 (transform.position.x, Camera.main.transform.position.y - 0.05f, transform.position.z);
 	}
	 	// Update is called once per frame
	void Update ()
	{
 
		if (Input.GetAxis ("Vertical") == 0) {
 			transform.localScale = Vector3.one;//new Vector3 ( 0.1f , 0.1f , 0.1f );//Vector3.one;
 

		} else {
 			transform.localScale = Vector3.zero;
 			transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);
 			transform.position = Camera.main.transform.position + Camera.main.transform.forward * 0.05f;
			transform.position = new Vector3 (transform.position.x, Camera.main.transform.position.y - 0.05f, transform.position.z);
           
		}

	}
}
