using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
   public Transform player;
   private void Update() {
       transform.LookAt(player);
   }
}
