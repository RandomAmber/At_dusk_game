using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleted : MonoBehaviour
{
    public GameObject Player;
    public GameObject Player2;
    public GameObject CompletedPanel;


    private void OnTriggerEnter2D(Collider2D other) {
        
        if((other.gameObject == Player) || (other.gameObject == Player2)){
            other.gameObject.SetActive(false);
             CompletedPanel.SetActive(true);

    }
}

    public void Story1(){
        SceneManager.LoadScene("Story1");
}

}
