using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayStoryButtonHandler : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Story Page", LoadSceneMode.Additive);
    }
}
