using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_test : MonoBehaviour
{
   public GameObject witch1, witch2;
   GameObject player;
   public float lerpSpeed = 0.5f;
   private Vector3 offset;

   void Start(){
    //get the curent offset between player and camera positions
    offset = transform.position - witch1.transform.position;

   }

       void Update() {
        if(witch1.activeSelf){
        player = witch1;
    }
    else{
        player = witch2;
    }

    transform.position = Vector3.Lerp(
        transform.position, //current camera position
        player.transform.position + offset, // new position + original offset
        lerpSpeed); //the speed of smoothing
    
   }
}