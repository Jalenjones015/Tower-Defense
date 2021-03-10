using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool ispaused = false;
    public GameObject pausemenu;
    public GameObject allon;

    public void Pausep()
    {
        if (ispaused)
        {
            Time.timeScale = 1;
            ispaused = false;
            Debug.Log("unpause");
            pausemenu.SetActive(false);
            allon.SetActive(true);
        }
        else 
        {
            Time.timeScale = 0;
            ispaused = true;
            Debug.Log("pause");
            pausemenu.SetActive(true);
            allon.SetActive(false);
        }
    }
    //public void ifpause()
    //{
    //    if (ispaused == true)
    //    {
    //        pausemenu.SetActive(true);
    //        Debug.Log("Active");
    //    }
        
    //}
}
