using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AuthorText : MonoBehaviour


{
public GameObject[] Texts;
public GameObject[] Pictures;
    void Start(){

        for(int i = 0; i < Texts.Length; i++){
            StartCoroutine(wait_fadeIn(Pictures[i].GetComponent<SpriteRenderer>(), Texts[i].GetComponent<TextMeshProUGUI>(), 2f));
            //Texts[i].SetActive(true);
        }

}

     IEnumerator wait_fadeIn(SpriteRenderer MyRenderer, TextMeshProUGUI MyText, float duration){
        float counter = 0;
        Color spriteColor = MyRenderer.material.color;
        while (counter < duration){
            counter += Time.deltaTime;
            //Fade in from 0 to 1
            float alpha = Mathf.Lerp(0, 1, counter/duration);
            //Change alpha
            MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
            MyText.color = new Color(MyText.color.r, MyText.color.g, MyText.color.b, alpha);
            yield return null;
        }
        }
        
    }



        