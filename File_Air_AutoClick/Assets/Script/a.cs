using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour {

	 
	void Update () {
       gameObject.GetComponent<Renderer>().material.renderQueue = 3020;

    }
}
