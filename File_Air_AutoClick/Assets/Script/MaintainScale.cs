using UnityEngine;

public class MaintainScale : MonoBehaviour {

	private float initialRatio;
	private float directionalScale;

	void Start ( ) {

		initialRatio = ( Vector3.Distance ( transform.position , Camera.main.transform.position ) ) / transform.localScale.magnitude; // initialDistanceFromCamera / initialLabelScale's magnitude
	}

	void LateUpdate ( ) {

		directionalScale = Mathf.Sqrt ( ( Mathf.Pow ( ( Vector3.Distance ( transform.position , Camera.main.transform.position ) / initialRatio ) , 2 ) ) / 3 );	// sqrt of ( sqr of currentScaleMagnitude / 3 ) , currentScaleMagnitude = currentDistanceFromCamera /  initialRatio

		transform.localScale = new Vector3 ( directionalScale , directionalScale , directionalScale );	// Assign directionalScale to all directions

	}

}