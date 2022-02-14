using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public int levelInt;
    private void Start() 
    {
    levelInt=PlayerPrefs.GetInt("LevelIndex");
    }

    public void SaveGame()
    {
        PlayerPrefs.DeleteKey("LevelIndex");
        PlayerPrefs.SetInt("LevelIndex",SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(levelInt,LoadSceneMode.Single);
    }
}
