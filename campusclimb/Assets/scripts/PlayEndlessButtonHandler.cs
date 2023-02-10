using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayEndlessButtonHandler : MonoBehaviour
{
  
    public void OnButtonClick()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Game Page", LoadSceneMode.Additive);
    }


}
