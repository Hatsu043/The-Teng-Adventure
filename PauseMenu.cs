using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool OpenedInventory = false;

    public GameObject pauseMenuUI;
    public GameObject inventory;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))  //Open pause menu button
        {
            if(GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.B))  //Open inventory button
        {
            if (OpenedInventory)
            {
                Closed();
            }
            else
            {
                Opened();
            }
        }

    }

    public void Resume()  //Close pause menu
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()  //Open pause menu
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Option()  //Load option scene
    {
        Time.timeScale = 1f;
        Debug.Log("Option...");
        SceneManager.LoadScene("Option");
    }

    public void LoadMenu()  //Load menu scene
    {
        Time.timeScale = 1f;
        Debug.Log("Loading menu...");
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()  //Exit gameplay and go to main menu
    {
        Debug.Log("Quitting game...");
        SceneManager.LoadScene("MainMenu");
    }

    void Opened()  //Open inventory
    {
        inventory.SetActive(true);
        Time.timeScale = 0f;
        OpenedInventory = true;
    }

    public void Closed()  //Close inventory
    {
        inventory.SetActive(false);
        Time.timeScale = 1f;
        OpenedInventory = false;
    }

}
