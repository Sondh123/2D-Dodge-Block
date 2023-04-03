using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pausePanel;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1f)
            {
                PauseGameObj();        
            }
            else UnPauseObj();
        }
    }

    public void PauseGameObj()
    {
        FindObjectOfType<SoundManager>().Play("Pause");
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }

    public void UnPauseObj()
    {
        FindObjectOfType<SoundManager>().Play("UnPause");
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
}
