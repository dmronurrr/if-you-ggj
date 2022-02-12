using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pill : MonoBehaviour
{
    [SerializeField]private Rigidbody rb;
    [SerializeField]private BoxCollider boxCollider;
    [SerializeField]private Transform playerHands;
    [SerializeField]private Renderer render;
    LevelController levelController;
    public bool canAttack;
    
    public bool isHolding=false;
    private void Start() {
    levelController=GameObject.Find("EventSystem").GetComponent<LevelController>();
    }
    public void OnHand()
    { 
        this.transform.position=playerHands.position;
        this.transform.rotation=playerHands.rotation;
        rb.isKinematic=true;
        boxCollider.enabled=false;
        isHolding=true;
        if(levelController.index!=3)
        {
            if(Input.GetMouseButton(0))
            { 
            levelController.StartCoroutine(nameof(levelController.NextLevel));
            render.enabled=false;
            isHolding=false;
            }
        }
        else
        {   
            if(Input.GetMouseButton(0))
            {
            render.enabled=false;
            isHolding=false; 
            canAttack=true;
            }
        }
        
    } 
    private void Update() 
    {
        if(isHolding)
        {
            OnHand();
        }
        else
        {
            rb.isKinematic=false;
            boxCollider.enabled=true;
        }
    }
}
