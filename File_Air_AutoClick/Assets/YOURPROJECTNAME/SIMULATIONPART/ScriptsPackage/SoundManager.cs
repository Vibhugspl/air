using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public static SoundManager instance;

	public AudioClip ClickSound;
	public AudioClip RightSound;
	public AudioClip WrongSound;

	[ HideInInspector ]
	public AudioSource asc;

	void Start ( ) {

		if ( instance != null && instance != this ) {

			Destroy ( this.gameObject );
		
		} else if ( instance == null ) {

			instance = this;

		}

		DontDestroyOnLoad ( this );

		asc = GetComponent < AudioSource > ( );

	}

	public void PlayClickSound ( ) {

		instance.asc.PlayOneShot ( ClickSound );

	}

	public void PlayRightSound ( ) {

		instance.asc.PlayOneShot ( RightSound );

	}

	public void PlayWrongSound ( ) {

		instance.asc.PlayOneShot ( WrongSound );

	}

	public void PlayAudioClip ( AudioClip audioClip ) {

		instance.asc.PlayOneShot ( audioClip );

	}

}