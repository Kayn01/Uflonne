using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    public void GoToScene(int idScene)
    {
        SceneManager.LoadScene(idScene);
    }

    public void GoToScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
