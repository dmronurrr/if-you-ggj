using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareTrigger : MonoBehaviour
{
    JumpScare jumpScare;
    private void Start() 
    {
        jumpScare=GameObject.Find("JS").GetComponent<JumpScare>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {
            if(jumpScare!=null)
            {
                jumpScare.Triggered();
            }
        }   
    }
}
