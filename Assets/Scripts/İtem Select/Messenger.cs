using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messenger : MonoBehaviour
{
    public SelectionManager selectionManager;
    public string mesage;
    public GameObject paper;
    private void Update()
    {
        if(selectionManager.paper)
        {
            paper.SetActive(true);
        }
        else
        {
           paper.SetActive(false);
        }
    }
}
