using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Story : MonoBehaviour
{

    public int[] GotCollected;
    public GameObject[] GotPictured;
    public GameObject[] Stories;
    public GameObject Candle;
    public GameObject Chest;
    public GameObject Book;
    public GameObject Plant;
    public GameObject Jar;
    public GameObject Key;
    public GameObject Axe;


void Start(){
    int NumCollected = GameManager.Collected.Length;
    GotCollected = new int[NumCollected];
    GotPictured = new GameObject[] {Candle, Chest, Book, Plant, Jar, Key, Axe};
    for(int i = 0; i < NumCollected; i++){
        if(GameManager.Collected[i]!=GameManager.UnrealNumber){
             StartCoroutine(wait_fadeIn(GotPictured[i].GetComponent<SpriteRenderer>(), Stories[i].GetComponent<TextMeshProUGUI>(), 2f));
            //GotPictured[GameManager.Collected[i]].GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 2f);
            //Stories[GameManager.Collected[i]].SetActive(true);
        }
        
        // GotCollected[i] = GameManager.Collected[i];
        // for (int j = 0; j < GotPictured.Length; j++){
        //     if (GotCollected[j] != 0){
        //         GotPictured[j].GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 2f);
        //     }

        // }
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




// public class AuthorText : MonoBehaviour


// {
// public GameObject[] Texts;
// public GameObject[] Pictures;
//     void Start(){

//         for(int i = 0; i < Texts.Length; i++){
//             StartCoroutine(wait_fadeIn(Pictures[i].GetComponent<SpriteRenderer>(), Texts[i].GetComponent<TextMeshProUGUI>(), 2f));
//             //Texts[i].SetActive(true);
//         }

// }

//      IEnumerator wait_fadeIn(SpriteRenderer MyRenderer, TextMeshProUGUI MyText, float duration){
//         float counter = 0;
//         Color spriteColor = MyRenderer.material.color;
//         while (counter < duration){
//             counter += Time.deltaTime;
//             //Fade in from 0 to 1
//             float alpha = Mathf.Lerp(0, 1, counter/duration);
//             //Change alpha
//             MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
//             MyText.color = new Color(MyText.color.r, MyText.color.g, MyText.color.b, alpha);
//             yield return null;
//         }
//         }
        
//     }



        