using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air_Manager : MonoBehaviour {

    private static Air_Manager instance;
    public static Air_Manager  Instance
        {
        get
        {
        if(instance==null)
        {
        GameObject go = new GameObject("Game");
                go.AddComponent<Air_Manager>();
        }
            return instance;
         }
         }


    public void Start()
    {
        instance = this;

        

         
    }



    public void StartSim() {
        MovementController.Instance.ControllerMovement = true;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void CallAiro()
    {
        StartCoroutine(MoveAiro());
        StartCoroutine(PlayAudio());

    }

    public AudioSource audioObject;

    IEnumerator PlayAudio()
    {
        yield return new WaitForSeconds(2);
        audioObject.Play();
    }




    public GameObject question;
    IEnumerator MoveAiro()
    {
        yield return new WaitForSeconds(15);
        question.SetActive(true);

    }
}
