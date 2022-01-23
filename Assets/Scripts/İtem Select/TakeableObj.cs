using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeableObj : MonoBehaviour
{
    public SelectionManager selectionManager;
    public MouseLook mouseLook;
    public PlayerController playerController;
    [SerializeField]private Rigidbody rb;
    [SerializeField]private BoxCollider boxCollider;
    [SerializeField]private Transform playerHands;
    [SerializeField]private Animator animator;
    [SerializeField]Pill pill;
    private void Update() 
    {
        if(selectionManager.inPosition)
        {
            this.transform.position=playerHands.position;
            this.transform.rotation=playerHands.rotation;
            rb.isKinematic=true;
            boxCollider.enabled=false;
            if(Input.GetMouseButton(0))
            {    
                    selectionManager.go();     
            }

            
        }
        else
        {
            rb.isKinematic=false;
            boxCollider.enabled=true;
        }
    }
    public void NextLevelWithAnimation()
    {
        Destroy(mouseLook);
        Destroy(playerController);
        Destroy(this.gameObject);
        animator.Play("CloseEyes");
    }
}