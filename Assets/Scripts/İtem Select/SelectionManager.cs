using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    [SerializeField]private string selectableTag="Selectable";
    public MouseLook mouse;
    public bool inPosition,paper;
    public Transform playerHands;
    public Camera cam;
    float _distance;
    public TakeableObj takeableObj;
    public float maxDistance;
    public Messenger messenger;
    public GameObject image;
    public Text text;
    public float distance;
    private void Update()
    {
        
        _distance=distance;
        if(Input.GetKey(KeyCode.Q)&&paper)
        {
            mouse.enabled=true;
            paper=false;
        }
        if(Input.GetKey(KeyCode.Q)&&inPosition)
        {
            inPosition=false;
        }
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            distance= Vector3.Distance(playerHands.position,hit.transform.position);
            Transform selection = hit.transform;
            if(selection.CompareTag(selectableTag)&&_distance<maxDistance)
            {
                if(Input.GetKey(KeyCode.E)&&inPosition==false)
                {
                    inPosition=true;
                }  
            }
            if(selection.CompareTag("Messenger")&&_distance<maxDistance)
            {
                messenger=selection.gameObject.GetComponent<Messenger>();
                if(Input.GetKey(KeyCode.E)&&paper==false)
                {
                    text.text=messenger.mesage;
                    mouse.enabled=false;
                    paper=true; 
                }  
            }
            Debug.Log(hit);
        }
    }
}
