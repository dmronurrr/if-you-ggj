using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pill : MonoBehaviour
{
    public bool isUsing;
    public bool canAttack;
    public SelectionManager selectionManager;
    public Camera cam;
    [SerializeField]private Rigidbody rb;
    [SerializeField]private BoxCollider boxCollider;
    [SerializeField]private Transform playerHands;
    [SerializeField]private Renderer render;
    public GameObject breakable;
    public GameObject ground;
    public float distance;
    private void Update() 
    {
        breakable=GameObject.FindGameObjectWithTag("Breakable");
        if(breakable==null && canAttack)
        {
            Destroy(ground);
        }
        if(canAttack)
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
        {
            distance= Vector3.Distance(playerHands.position,hit.transform.position);
            Transform selection = hit.transform;
            if(selection.CompareTag("Breakable")&&distance<6)
            {
                if(Input.GetMouseButton(0))
                {
                    Destroy(selection.gameObject);
                }
            }
        }
        }
        if(selectionManager.isTake)
        {
            this.transform.position=playerHands.position;
            this.transform.rotation=playerHands.rotation;
            rb.isKinematic=true;
            boxCollider.enabled=false;
            if(Input.GetMouseButton(0))
            {
                render.enabled=false;
                canAttack=true;

            }
        }
        else
        {
            rb.isKinematic=false;
            boxCollider.enabled=true;
        }
    }
    
}
