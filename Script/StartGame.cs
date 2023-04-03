using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public void StartGameplay(string Map)
    {
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
        SceneManager.LoadScene(Map, LoadSceneMode.Additive);
    }



}
