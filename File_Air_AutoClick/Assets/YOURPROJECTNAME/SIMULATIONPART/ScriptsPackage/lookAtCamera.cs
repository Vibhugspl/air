using UnityEngine;
using System.Collections;

public class lookAtCamera : MonoBehaviour {

    public Transform Camera;

    void Update()
    {
        gameObject.transform.LookAt(Camera);
    }
        
}
