using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelStats : MonoBehaviour
{
    public LevelController levelController;
    public string[,] levels = new string[3,2]{{"111","LevelWithEyes"},{"222","LevelWithBad"},{"333","LevelWithCables"}};
    public HashSet<string> levelsPlayedSet = new HashSet<string>();
    public int currentLevel;
    void Update()
    {
        currentLevel=levelController.index;
        levelsPlayedSet.Add(levels[currentLevel,0]);   
    }
    public void SaveSystem()
    {
        LoadExistingLevels();
        LevelController levelController=GameObject.Find("EventSystem").GetComponent<LevelController>();
        levelController.NextLevel();
        string[] levelsPlayed = new string [levelsPlayedSet.Count];
        levelsPlayedSet.CopyTo(levelsPlayed);
        string currentLevelName = string.Join(",",levelsPlayed);
        PlayerPrefs.SetString("levelsPlayed",currentLevelName);
        Debug.Log(PlayerPrefs.GetString("levelsPlayed"));
    }
    public void LoadExistingLevels()
    {
        string backUpLevel = PlayerPrefs.GetString("levelsPlayed");
        string[] backUpLevels = backUpLevel.Split(',');
        for(int i=0;i<backUpLevels.Length;i++)
        {
            levelsPlayedSet.Add(backUpLevels[i]);
        }
        Debug.Log(backUpLevel + "BackUp Çalıştı");
        PlayerPrefs.DeleteKey("levelsPlayed");
    }
    
}
