using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Load : MonoBehaviour 
{
	public string Level_name;

	public static Level_Load Instance;
	void Awake()
	{
		
		if (Instance == null) {
			Instance = this;
			//DontDestroyOnLoad (gameObject);
		} 
//		else if (Instance != this) {
//			Destroy (this.gameObject);
//			return;
//		}
	}

	public void Load_Level(int Level_number)
	{
		PlayerPrefs.SetInt("Level_number", Level_number);

	}
	 
}
