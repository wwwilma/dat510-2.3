using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameButtonHandler : MonoBehaviour
{
    public void OnButtonClick()
    {
        Debug.Log("You have clicked the button");
        Application.Quit();
    }
}   
