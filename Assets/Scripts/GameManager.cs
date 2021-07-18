using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // Create instance of this gameObject
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {

        // Play menu bgm
        FindObjectOfType<AudioManager>().Play("Give_me_smile");
    }

    public void StartGame(int gameMode)
    {
        // If ABC button is pressed
        if(gameMode == 1)
        {
            print("Starting ABC game");
            FindObjectOfType<AudioManager>().Stop("Give_me_smile");
            FindObjectOfType<AudioManager>().Play("Button_click_01");
            SceneManager.LoadScene(1);
            FindObjectOfType<AudioManager>().Play("Happy-clap");
        }
        // if Animal button is pressed
        else if (gameMode == 2)
        {
            print("Starting Animal game");
            FindObjectOfType<AudioManager>().Stop("Give_me_smile");
            FindObjectOfType<AudioManager>().Play("Button_click_01");
            SceneManager.LoadScene(2);
            FindObjectOfType<AudioManager>().Play("Happy_clap");
        }
    }

    public void QuitGame()
    {
        print("Quit button pressed");
        Application.Quit();
    }

}
