using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public GameObject Candle;
    public GameObject CandleMarker;

    public GameObject Chest;
    public GameObject ChestMarker;

    public GameObject Book;
    public GameObject BookMarker;

    public GameObject Plant;
    public GameObject PlantMarker;

    public GameObject Jar;
    public GameObject JarMarker;

    public GameObject Key;
    public GameObject KeyMarker;

    public GameObject Axe;
    public GameObject AxeMarker;

    public GameObject[] Collectables;
    public GameObject[] CollectablesMarkers;
    public static int[] Collected;
    private int CollectableNumber = -1;
    public static int UnrealNumber = 9;

    //fade in / out
    public SpriteRenderer spriteToFade;



    private void Start(){

        Collectables = new GameObject[] {Candle, Chest, Book, Plant, Jar, Key, Axe};
        CollectablesMarkers = new GameObject[] {CandleMarker, ChestMarker, BookMarker, PlantMarker, JarMarker, KeyMarker, AxeMarker};
        Collected = new int[]{UnrealNumber, UnrealNumber, UnrealNumber, UnrealNumber, UnrealNumber, UnrealNumber, UnrealNumber};

    }
    

    private void OnTriggerEnter2D(Collider2D other) {
        if(CollectableNumber <= System.Array.IndexOf(Collectables, other.gameObject)){
            CollectableNumber = System.Array.IndexOf(Collectables, other.gameObject);
            CollectablesMarkers[CollectableNumber].GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 2f);
            Collected[CollectableNumber] = CollectableNumber;
            StartCoroutine(fadeOut(other.gameObject.GetComponent<SpriteRenderer>(), other.gameObject, 1f));
            for (int i = 0; i < CollectableNumber; i++){
                if (Collectables[i]){
                    Collectables[i].GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
                }
                
            }
        } 
        
    }


IEnumerator fadeOut(SpriteRenderer MyRenderer, GameObject other, float duration)
{
    float counter = 0;
    //Get current color
    Color spriteColor = MyRenderer.material.color;

    while (counter < duration)
    {
        counter += Time.deltaTime;
        //Fade from 1 to 0
        float alpha = Mathf.Lerp(1, 0, counter / duration);
        Debug.Log(alpha);

        //Change alpha only
        MyRenderer.color = new Color(spriteColor.r, spriteColor.g, spriteColor.b, alpha);
        //Wait for a frame
        yield return null;
    }
    Destroy(other);
 }
   
}



