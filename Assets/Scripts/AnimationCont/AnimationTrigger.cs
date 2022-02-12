using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public string selectableTag;
    public Camera cam;
    public float distance,maxDistance;
    public Transform playerHands;
    public GameObject hitObj;
    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if(Physics.Raycast(ray,out hit))
        {
            distance= Vector3.Distance(playerHands.position,hit.transform.position);
            Transform selection = hit.transform;
            if(selection.CompareTag(selectableTag)&&distance<maxDistance)
            {  
                hitObj=selection.gameObject.GetComponent<GameObject>();
                if(Input.GetKey(KeyCode.E))
                {
                    
                }
            }
        }
    }
        
}
