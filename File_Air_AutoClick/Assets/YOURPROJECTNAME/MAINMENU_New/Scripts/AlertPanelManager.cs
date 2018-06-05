using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AlertPanelManager : MonoBehaviour {

	public static AlertPanelManager apm;

	private Text alertMessageText;

	public void Awake ( ) {

		apm = this;
		alertMessageText = transform.GetChild ( 0 ).GetComponentInChildren < Text > (  );

	}

	public void ShowAlertPanel ( ) {

        transform.GetChild ( 0 ).gameObject.SetActive ( true );

	}

	public void HideAlertPanel ( ) {

        transform.GetChild ( 0 ).gameObject.SetActive ( false );

	}

	public void ShowAlertMessage ( string alertMessage ) {

		ShowAlertPanel (  );
		alertMessageText.text = alertMessage;
		Invoke ( "HideAlertPanel" , 4f );

	}

}
