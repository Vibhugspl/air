using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseApplication : MonoBehaviour {	 
	
	 public void CloseApp()
    {
        Application.Quit();
    }
    void Update() { 
    if (Input.GetKeyDown(KeyCode.Escape)) {
     // Application.Quit();
    }
}
}
