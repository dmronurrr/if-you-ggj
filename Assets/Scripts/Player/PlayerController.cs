using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField]private CharacterController controller;
    [Header("Character Variables")]
    [SerializeField]private float speed=12f;
    [Header("Gravity")]
    [SerializeField]private float gravity=-9.81f;
    [SerializeField]private Transform groundCheck;
    [SerializeField]private float groundDistance = 0.4f;
    [SerializeField]private LayerMask groundMask;
    [Header("Booleans")]
    [SerializeField]private bool isGrounded;
    Vector3 velocity;
    private void Update() 
    {
         isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z =Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * x + transform.forward * z;
        
        controller.Move(move*speed*Time.deltaTime);

        
        velocity.y+=gravity*Time.deltaTime; 
        controller.Move(velocity*Time.deltaTime);
        if(x!=0||z!=0)
        {

        }
        else
        {
        
        }
    }
}
