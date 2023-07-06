using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{

public float speed = 0.5f;
   private void Update(){
    transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
   }
}



           