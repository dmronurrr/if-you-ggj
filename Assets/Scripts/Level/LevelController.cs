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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);   
    }
}