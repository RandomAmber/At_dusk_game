using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   public GameObject player;
   public float lerpSpeed = 0.5f;
   private Vector3 offset;

   void Start(){
    //get the curent offset between player and camera positions
    offset = transform.position - player.transform.position;

   }

    void LateUpdate() {
    transform.position = Vector3.Lerp(
        transform.position, //current camera position
        player.transform.position + offset, // new position + original offset
        lerpSpeed); //the speed of smoothing
    
   }
}
