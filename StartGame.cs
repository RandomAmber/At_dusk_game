using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void startGame(){
        SceneManager.LoadScene("SampleScene");
    }

    public void map(){
        SceneManager.LoadScene("Map");

    }

    public void howto(){
        SceneManager.LoadScene("HowToPlay");
    }

    public void authors(){
        SceneManager.LoadScene("Authors");
    }

    public void menu(){
        SceneManager.LoadScene("Menu");
    }

    public void options(){
        SceneManager.LoadScene("Options");

    }

    public void exitGame(){
        Application.Quit();
    }
}
