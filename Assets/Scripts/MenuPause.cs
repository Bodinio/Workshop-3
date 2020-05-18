using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public bool GameIsPaused = false;

    public GameObject PauseMenuUI;

    private Gamemanager gamemanager;

    public string LevelName;

    /*    private void Start()
        {
            PauseMenuUI.SetActive(false);
        }
    */

    private void Start()
    {
        gamemanager = Gamemanager.s_Singleton;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (gamemanager.JaugePeur.fillAmount <= 0.5f)
        {
            gamemanager.Neutre.SetActive(true);
        }
        if (gamemanager.JaugePeur.fillAmount >= 0.5f)
        {
            gamemanager.Inquiet.SetActive(true);
            gamemanager.Neutre.SetActive(false);
        }
    }

    public void Resume ()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    /*  public void LoadMenu()
        {
            Debug.Log("Loading Menu...");
        }

    */
    public void QuitGame()
    {
        SceneManager.LoadScene(LevelName);
    }

}
