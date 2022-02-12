using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHoldItemManager : MonoBehaviour
{
    NewSelectionManager selectionManager;
    MouseLook mouse;
    PlayerController playerController;
    Messenger messenger;
    private void Start() 
    {
        mouse=Camera.main.GetComponent<MouseLook>();
        playerController=GameObject.Find("Player").GetComponent<PlayerController>();
        selectionManager=GameObject.Find("SelectionManager").GetComponent<NewSelectionManager>();
        
    }
    private void Update() 
    {
        if(selectionManager.messenger!=null)
        {
            messenger=selectionManager.messenger.GetComponent<Messenger>();
        }
        if(selectionManager.holdSomething)
        {
            if(messenger!=null)messenger.render.enabled=false; 
            playerController.speed=0;
            mouse.enabled=false;
            if(Input.GetKey(KeyCode.Q))
            {
                selectionManager.holdSomething=false;
            }
        }
        else
        {
            if(messenger!=null)messenger.image.SetActive(false);
            if(messenger!=null)messenger.render.enabled=true;
            selectionManager.holdObj=null;
            playerController.speed=2;
            mouse.enabled=true;
        }
    }
}
