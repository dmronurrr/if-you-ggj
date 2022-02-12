using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{
    public AnimationTrigger animationTrigger;
    public PlayerController playerController;
    public MouseLook mouseLook;
    AnimationTriggerObj animationTriggerObj;
    void Update()
    {
        if(animationTrigger.hitObj!=null)
        {
            switch(animationTriggerObj.index)
        {
            case 0:
            Debug.Log("PlayAnim");
            break;
        }
        }
        
    }
}
