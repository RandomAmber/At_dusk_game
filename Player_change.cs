using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_change : MonoBehaviour
{
    public GameObject witch1, witch2;
    int WitchIsOn = 1;

    void Start(){
         // anable first avatar and disable another one
		witch1.gameObject.SetActive (true);
		witch2.gameObject.SetActive (false);
    }


    void Update() {
    if(Input.GetKey(KeyCode.Space)){
        WitchIsOn +=1;
        if(WitchIsOn % 2 == 0){
            witch1.gameObject.SetActive (false);
            witch2.transform.position = witch1.transform.position;
		    witch2.gameObject.SetActive (true);
        }
        else{
            witch2.gameObject.SetActive (false);
            witch1.transform.position = witch2.transform.position;
            witch1.gameObject.SetActive (true);
        }
        
    }
    }
}
    



