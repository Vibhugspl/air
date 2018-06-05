using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {


    public GameObject highLight;
    public Animator airo;
    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "PlayerHit")
        {
            MovementController.Instance.ControllerMovement = false;
            highLight.SetActive(false);
            airo.SetBool("Sit", true);
            Air_Manager.Instance.CallAiro();
            other.name = "NoHit";
        }
    }
}
