using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewSelectionManager : MonoBehaviour
{
    [SerializeField]private string selectableTag="Selectable";
    MouseLook mouse;
    public bool holdSomething=false;
    PlayerController playerController;
    Camera cam;
    Pill pill;
    float distance;
    public float maxDistance;
    public Messenger messenger;
    public GameObject hitObj;
    public GameObject holdObj;
    private void Start() 
    {  
        playerController=GameObject.Find("Player").GetComponent<PlayerController>();
        cam=Camera.main;
        mouse=cam.GetComponent<MouseLook>();
    }
    private void Update()
    {  
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            Transform selection = hit.transform;
            hitObj=selection.gameObject;
            selectableTag=hitObj.tag;
            distance= Vector3.Distance(playerController.transform.position,hit.transform.position);
            if(distance<maxDistance)
            {
                switch(selectableTag)
            {

                case "Messenger":
                messenger=selection.gameObject.GetComponent<Messenger>(); 
                if(Input.GetKey(KeyCode.E)&&holdSomething==false)
                { 
                    holdSomething=true;
                    holdObj=messenger.gameObject;
                    messenger.OpenMessenger();
                }
                if(Input.GetKey(KeyCode.Q)&&holdSomething==true)
                {
                    holdSomething=false;
                    holdObj=null;
                    messenger.CloseMessenger(); 
                } 
                break;
                 case "Radio":
                 if(Input.GetKey(KeyCode.E))
                {
                    Radio radio=GameObject.Find("radio_lw").GetComponent<Radio>();
                    radio.PlayRadio();
                }
                break;
                case "Piano":
                if(Input.GetKey(KeyCode.E))
                {
                    Piano piano=GameObject.Find("piano_lw").GetComponent<Piano>();
                    piano.PlayPiano();
                }
                 break;
                 case "Pill":
                 if(Input.GetKey(KeyCode.E))
                { 
                    pill = GameObject.Find("Pill").GetComponent<Pill>();
                    pill.OnHand();
                    
                }
                 break;
                 case "Breakable":
                    pill = GameObject.Find("Pill").GetComponent<Pill>();
                    if(pill.canAttack)
                    {
                        if(Input.GetMouseButtonDown(0))
                        {
                            Destroy(hitObj.gameObject);
                        }
                    }
                 
                 break;
            }      
            }
        }
    }
}
