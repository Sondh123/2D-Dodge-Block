using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void GameOver()
    {
        //StartCoroutine(RestartLevel());
        gameOverPanel.SetActive(true);
        GetComponent<PlayerMove>().enabled = false;
    }
}
