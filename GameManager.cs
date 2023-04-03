using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


   
public class GameManager : MonoBehaviour
{
        public GameObject CreditUI;
        public float slowness = 10f; // slow motion khi ta thua
        public static GameManager instance;
        //[SerializeField] GameObject menuPanel;

    private void Awake()
    {
        instance = this;
    }

        public Transform playerTransform;



    private void Start()
    {
      
    }


    public void EndGame() 
    {

    }

    IEnumerator TimeSlow()
    {

        Time.timeScale = 1f / slowness; // khien time chay se giam tan toi 0.1 frame/s
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness; // de xu ly hinh anh duoc muot hon

        yield return new WaitForSeconds(2f / slowness);
        // luu y la khi xai timeScale se anh huong den waitForSeconds() 
        // vi vay phai chia cho so sloness de chay dung so second 

        Time.timeScale = 1f; // reset time ve bt
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness; // tra lai fixdeltaTime ban dau
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void exitgame()
        {
                    
            // Tắt game
            Application.Quit();
        }

    public void openCredit()
    {
            CreditUI.SetActive(true);
            

    }

    public void closeCredit()
        {
            CreditUI.SetActive(false);
        }

    public void startgame()
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

    public void returnToMenu()
    {
                 
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
