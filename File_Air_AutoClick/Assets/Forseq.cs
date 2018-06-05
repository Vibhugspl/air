using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class Forseq : MonoBehaviour {
    
     void  Start ()
    {
        StartCoroutine (TestMapApi("http://103.83.81.139:33256/vibhuUnity/testApi"));
    }
     IEnumerator TestMapApi(string url)

    { WWW www = new WWW (url);

        yield return www;

        var a = new LitJson.JsonReader(www.text);

        JsonData data = JsonMapper.ToObject(a);

        int ResultValue=(int)data["result"];

        if (ResultValue == 1)
        {
            Debug.Log ("yup iḿ done"); }
    }
}