using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public string SceneName;

    public GameObject MenuPause;

    public void PlayGame()
    {
        Time.timeScale = 1f;
        if (SceneManager.GetActiveScene().name != "MapSelection" && SceneManager.GetActiveScene().name != "MainMenu" && SceneManager.GetActiveScene().name != "cinematique" && SceneManager.GetActiveScene().name != "Finale")
        {
            MenuPause.GetComponent<MenuPause>().GameIsPaused = false;
            MenuPause.SetActive(false);
        }
        Debug.Log("LoadScene");
        Debug.Log(SceneName);
        StartCoroutine(LoadLevel(SceneName));
    }

    IEnumerator LoadLevel(string SceneName)
    {
        Debug.Log("N'importe quoi");

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(SceneName);
    }

    public void QuitGame()
    {
        Debug.Log("HELP");
        Application.Quit();
    }
}