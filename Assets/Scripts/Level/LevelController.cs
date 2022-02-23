using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;


public class LevelController: MonoBehaviour
{
    public int index;
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartGame()
    {
        PlayerPrefs.DeleteKey("Ending");
        PlayerPrefs.DeleteKey("LevelIndex");
        PlayerPrefs.DeleteKey("levelsPlayed");
        SceneManager.LoadScene("Scene1");

    }
    public void Quit()
    {
        Application.Quit();
    }
    //create IEnumerator for next level 
    public IEnumerator NextLevel()
    {
        PlayerController playerController=GameObject.Find("Player").GetComponent<PlayerController>();
        MouseLook mouse=Camera.main.GetComponent<MouseLook>();
        playerController.speed=0;
        mouse.enabled=false;
        yield return new WaitForSeconds(5f);
        int levelInt=SceneManager.GetActiveScene().buildIndex == 3 ? 0 : SceneManager.GetActiveScene().buildIndex +1;
        SceneManager.LoadScene(levelInt); 
        PlayerPrefs.DeleteKey("LevelIndex");
        PlayerPrefs.SetInt("LevelIndex",levelInt);
    }
    public void LastLevel()
    {
        EndingCalculate endingCalculate=GameObject.Find("EndingCalculate").GetComponent<EndingCalculate>();
        if(endingCalculate.ending>10)
        {
            //SceneManager.LoadScene("Scene2");
        }
        else
        {
            //SceneManager.LoadScene("Scene1");
        }
        
    }
}