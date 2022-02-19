using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicesAnimation : MonoBehaviour
{
    private Animator animator;

    public Animation [] animations;
    public MakeChoices [] makeChoices;
    public int animationNumber;
    public int index;
    private void Start() 
    {
        animator=GetComponent<Animator>();
    }
    private void Update() 
    {
    }
    public void WhenAnimationStart()
    {
        for(int i=animationNumber;i<animations.Length;i++)
        {  
            if(i<animations.Length)
            {
                animations[i].Play();
                makeChoices[i].Deactive();
                break;
                
            }      
        }
    }
    public void WhenAnimationFinish()
    {
        for(int i=0;i<makeChoices.Length;i++)
        { 
                makeChoices[i].Active();       
        }
    }
}
