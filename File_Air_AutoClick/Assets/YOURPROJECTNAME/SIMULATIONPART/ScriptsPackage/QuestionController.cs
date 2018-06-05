using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

[System.Serializable]
public  class QuestionData {
	public string QuestnName;
	public string QuestionID;
	public GameObject QuestionGameObject;
	public List<string> QuestionOptions;
	public GameObject CorrectOption;
}

public class QuestionController : MonoBehaviour
{
	public static QuestionController Instance;

	public List<QuestionData> questionData;

	public int CurrentQuestionCounter = 0;

    public GameObject  score_text;

	public GameObject wellDone,tryAgain;

	int wrongOptionClickCounter = 0;
	bool optionClicked = false;

    // Use this for initialization
    void Start()
    {
        Instance = this;
    }

    void Update()
	{
	}

    void scoreCount()
    {
        if (wrongOptionClickCounter == 0)
        {
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 5);
        }
        if (wrongOptionClickCounter == 1)
        {
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 3);
        }
        if (wrongOptionClickCounter == 2)
        {
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 2);
        }
        wrongOptionClickCounter = 0;
    }
		
    public void RightOption()
    {
		if (!optionClicked )
        {
            optionClicked = true;

			if (wrongOptionClickCounter > 2) {
					questionData[CurrentQuestionCounter].CorrectOption.GetComponentInChildren<Text> ().color = new Color32 (105, 223, 0, 255);
				questionData [CurrentQuestionCounter].CorrectOption.GetComponentInChildren<Image> ().raycastTarget = false;
				StartCoroutine(RightOption_waitTime());
                wrongOptionClickCounter = -1;
            }
			else {
				SoundManager.instance.PlayRightSound();
				questionData[CurrentQuestionCounter].CorrectOption.GetComponentInChildren<Text> ().color = new Color32 (105, 223, 0, 255);
				questionData [CurrentQuestionCounter].CorrectOption.GetComponentInChildren<Image> ().raycastTarget = false;
				wellDone.SetActive(true);
				StartCoroutine(RightOption_waitTime());
			}
			scoreCount();
        }
    }

    public void wrongOption(GameObject Option)
    {
        if (!optionClicked)
        {
			Option.GetComponent <Image>().raycastTarget = false;
            optionClicked = true;
			SoundManager.instance.PlayWrongSound ();
			wrongOptionClickCounter++;
            Option.GetComponentInChildren<Text>().color = new Color32(255, 0, 32, 255); 
			if (wrongOptionClickCounter <= 2) {
				tryAgain.SetActive(true);
			}else{
				questionData [CurrentQuestionCounter].CorrectOption.GetComponentInChildren<Image> ().raycastTarget = false;
			}
			StartCoroutine(wrongOption_waitTime(Option));
        }
    }

	IEnumerator wrongOption_waitTime(GameObject Option)
    {
        yield return new WaitForSeconds(1f);
		tryAgain.SetActive(false);
        optionClicked = false;
		if (wrongOptionClickCounter > 2) {
			RightOption ();
		}
    }

    IEnumerator RightOption_waitTime()
    {
        yield return new WaitForSeconds(1f);
		questionData [CurrentQuestionCounter].QuestionGameObject.SetActive (false);

		CurrentQuestionCounter++;
		if (CurrentQuestionCounter < questionData.Count && questionData [CurrentQuestionCounter].QuestionGameObject != null) {
			questionData [CurrentQuestionCounter].QuestionGameObject.SetActive (true);
		}
        wellDone.SetActive(false);
      
        optionClicked = false;
    }

}
