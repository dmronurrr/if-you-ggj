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
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("LevelIndex",SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadGame()
    {
        levelInt=PlayerPrefs.GetInt("LevelIndex");
        SceneManager.LoadScene(levelInt,LoadSceneMode.Single);
    }
}
