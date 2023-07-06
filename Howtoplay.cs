using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Howtoplay : MonoBehaviour
{

    public GameObject[] Items;
    public GameObject Things;
    public GameObject Markers;
    void Start(){

    StartCoroutine(wait());
    
}


    IEnumerator wait(){
        for(int i = 1; i <Items.Length; i++){
            if(i == 2){
                Things.SetActive(true);
            }else{
                Things.SetActive(false);
            }
            if(i==5){
                Markers.SetActive(true);
            }else{
                Markers.SetActive(false);
            }
            Items[i-1].SetActive(false);
            Items[i].SetActive(true);
            yield return new WaitForSeconds(5f);
        }
        SceneManager.LoadScene("Menu");
    }
        
    }


