using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{

    public GameObject[] Menu;

    public void LoadOptions()
    {
        for (int i = 0; i < Menu.Length; i++)
        {
            if(Menu[i].name == "OptionsMenu")
            {
                Menu[i].SetActive(true);
            }

            if (Menu[i].name != "OptionsMenu")
            {
                Menu[i].SetActive(false);
            }
        }
    }

    public void ToMainMenu()
    {
        for (int i = 0; i < Menu.Length; i++)
        {
            if (Menu[i].name == "MainMenu")
            {
                Menu[i].SetActive(true);
            }

            if (Menu[i].name != "MainMenu")
            {
                Menu[i].SetActive(false);
            }
        }
    }

    public void ToPauseMenu()
    {
        for (int i = 0; i < Menu.Length; i++)
        {
            if (Menu[i].name == "PauseMenu")
            {
                Menu[i].SetActive(true);
            }

            if (Menu[i].name != "PauseMenu")
            {
                Menu[i].SetActive(false);
            }
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void TogglepauseMenu()
    {
        for (int i = 0; i < Menu.Length; i++)
        {
            if (Menu[i].name == "PauseMenu")
            {
                if (Menu[i].gameObject.activeInHierarchy)
                {
                    Menu[i].SetActive(false);
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    FindObjectOfType<PauseManager>().TogglePause();
                }
                else
                {
                    Menu[i].SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    FindObjectOfType<PauseManager>().TogglePause();
                }
            }
        }
    }


    public void ToMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
