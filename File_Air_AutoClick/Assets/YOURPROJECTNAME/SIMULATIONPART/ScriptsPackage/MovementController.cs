using UnityEngine;
using System.Collections;
using UnityEngine.VR;


[RequireComponent(typeof(CharacterController))]
public class MovementController : MonoBehaviour {
	public static MovementController Instance;
	public float speed = 3.0F;
    public float rotateSpeed = 2.0F;
 	private CharacterController controllor;	
    public static float curSpeed;
    private Transform vrHead;
    public bool ControllerMovement;
    public float rotateAngle = 20;
    void Start(){
		Instance = this;
		controllor = GetComponent<CharacterController>();
 		vrHead = Camera.main.transform;
 	}

	void Update() {
        if (ControllerMovement)
        {
            //transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
            if (Input.GetButtonDown("Horizontal"))
                transform.Rotate(0, rotateAngle * Input.GetAxisRaw("Horizontal"), 0);
             Vector3 forward = vrHead.TransformDirection(Vector3.forward);
            curSpeed = speed * Input.GetAxis("Vertical");
            controllor.SimpleMove(forward * curSpeed);
        }
	
    }
}


 