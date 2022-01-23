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
    public PlayerController playerController;
    public Camera cam;
    float _distance;
    public TakeableObj takeableObj;
    public float maxDistance;
    public Messenger messenger;
    public GameObject image;
    public bool isPlay;
    public Text text;
    public float distance;
    Counter counter;
    public Renderer render;
    public int time;
    private void Start() {
        counter=new Counter();
        
    }
    private void Update()
    {
        
        _distance=distance;
        if(Input.GetKey(KeyCode.Q)&&paper)
        {
            playerController.speed=2;
            render.enabled=true;
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
                Debug.Log("çalışıyor");
                if(Input.GetKey(KeyCode.E)&&inPosition==false)
                {
                    inPosition=true;
                }  
            }
            if(selection.CompareTag("Messenger")&&_distance<maxDistance)
            {  
                messenger=selection.gameObject.GetComponent<Messenger>();
                render=messenger.GetComponent<Renderer>();
                if(Input.GetKey(KeyCode.E)&&paper==false)
                {
                    playerController.speed=0;
                    render.enabled=false;
                    text.text=messenger.mesage;
                    mouse.enabled=false;
                    paper=true; 
                    counter.Up();
                }  
            }
            if(selection.CompareTag("Radio")&&_distance<maxDistance)
            {
                if(Input.GetKey(KeyCode.E))
                {
                    isPlay=true;
                }
            }
            if(selection.CompareTag("Piano")&&_distance<maxDistance)
            {
                if(time>=2)
                {
                    if(Input.GetKey(KeyCode.E))
                    {
                        piano=true;
                        takeableObj.NextLevelWithAnimation();
                    }
                }
            }
            Debug.Log(hit);
            time=counter.counter;
        }
    }
   public bool piano; 
}
