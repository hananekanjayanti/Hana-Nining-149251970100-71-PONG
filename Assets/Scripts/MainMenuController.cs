using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");

    }

    // public void openAuthor()
    // {
    //     Debug.Log("Created By: Hana Nining - 149251970100-71");
    // }
}
