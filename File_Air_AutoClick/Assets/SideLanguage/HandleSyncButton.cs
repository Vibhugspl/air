using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class HandleSyncButton : MonoBehaviour
{
    public static HandleSyncButton Instance;

     public GameObject crossButton;

    public bool mode;
    private Vector3 crossButtonPosition;

    Vector3 _intial;

    void Awake()
    {
        Instance = this;
		_intial = crossButton.transform.localPosition;
    }

    void Start()
    {
     
    }

    public void Swap_Btns()
    {
        if (LanguageHandler.instance.IsLeftToRight)
        {			
			crossButton.transform.localPosition = _intial;
        }
        else
        {
			crossButton.transform.localPosition = new Vector3(-1*_intial.x, _intial.y, _intial.z);
        }

        #if !UNITY_EDITOR
        mode = PlayerPrefs.GetInt ( "mode" ) != 0 ? true : false ;
        #endif

        if (mode)
        {
            crossButton.SetActive(false);
        }
        else
        {
            crossButton.SetActive(true);
        }
    } 
}