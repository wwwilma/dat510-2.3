using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadScene: MonoBehaviour
{
	public Text lodingText;
	public Image progressBar;
	private int CurProgressValue = 0;

	void FixedUppdate()
	{
		int progressValue = 100;


		if (CurProgressValue < progressValue)
		{
			CurProgressValue++;
		}

		lodingText.text = "loading..." + CurProgressValue + "%"; //uppdate progress percentage

		progressBar.fillAmount = CurProgressValue / 100f; //uppdate fill amount image

		if (CurProgressValue == 100)
		{
			lodingText.text = "OK";
			SceneManager.LoadScene("Game page");
		}

    }
}

