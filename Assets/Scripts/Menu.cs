using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    bool ispaused = false;
    public GameObject Pausepiece;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Start");
    }

    public void Credits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        Debug.Log("Start");
    }

    public void Howto()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Debug.Log("Start");
    }

    public void close()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Back");
    }

    public void How2back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        Debug.Log("Back");
    }

    public void Crediback()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        Debug.Log("Back");
    }

    public void Pause()
    {
        if (ispaused)
        {
            Time.timeScale = 1;
            ispaused = false;
            Debug.Log("Pause");
        }
        else
        {
            Time.timeScale = 0;
            ispaused = true;
        }
    }
}
