using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionButtonHandler : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Options", LoadSceneMode.Additive);
    }
}
