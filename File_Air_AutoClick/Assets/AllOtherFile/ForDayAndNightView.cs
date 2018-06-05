using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForDayAndNightView : MonoBehaviour {

    public static ForDayAndNightView Instance;

    public bool checkView=true;

    void Start()
    {
        Instance = this;
    }  
    
    public void StopAnimation()
    {
        if (checkView)
        {
            gameObject.GetComponent<Animation>().Stop();
            checkView = false;
        }
    }
}