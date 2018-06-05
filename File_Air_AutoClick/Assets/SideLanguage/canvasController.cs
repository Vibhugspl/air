using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class canvasController : MonoBehaviour {
    public static canvasController Instance;
  
    public GameObject Languagebutton;
	public List<string> languages;
  public	List<GameObject> buttons =new List<GameObject>() ;

	void Start(){

      
        Instance = this;
      
        buttons.Add (Languagebutton);
		for (int i = 1; i < languages.Count; i++) {
			GameObject temp = Instantiate (Languagebutton, Languagebutton.transform.parent) as GameObject;
			temp.GetComponentInChildren<Text> ().text = languages [i];
			buttons.Add(temp);
		}
          buttons[languages.IndexOf(PlayerPrefs.GetString("currentLanguage"))].GetComponentInChildren<Text>().color = new Color32(105, 223, 0, 255);


    }

    public void OnClose(){
		Application.Quit ();
	}

	public void OnClickLanguageButton(Text Buttontext){
		makeDefaultcolor ();
      
        //LanguageHandler.instance.currentLanguage =  ( LanguageHandler.Language ) languages.IndexOf(Buttontext.text);
        //PlayerPrefs.SetString("currentLanguage", LanguageHandler.instance.currentLanguage.ToString());
        //Buttontext.color = new Color32(105, 223, 0, 255);
        //LanguageHandler.instance.changeLanguageUpdate();
       

     

    }

    void makeDefaultcolor(){
		for (int i = 0; i < buttons.Count; i++) {
			buttons[i].GetComponentInChildren<Text>().color = new Color32 (233,233,233,255);

		}
	}

	public void OnOffTable(GameObject Table){
		Table.SetActive (!Table.activeInHierarchy);
	}
}
