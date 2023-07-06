using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AboutText : MonoBehaviour
{
    public GameObject[] Texts;

void Update() {
    if(Input.GetKey(KeyCode.Space)){
        SceneManager.LoadScene("Menu");
    }
    
}
void Start(){
    
    StartCoroutine(wait());
    
}

    IEnumerator wait(){
        for(int i = 1; i <Texts.Length; i++){
            Texts[i-1].SetActive(false);
            Texts[i].SetActive(true);
            yield return new WaitForSeconds(5f);
        }
        SceneManager.LoadScene("Menu");
        
    }

}

