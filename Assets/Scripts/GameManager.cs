using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour //Overall game manager
{
    private GameObject player;
    public static GameManager instance = null; //Singleton pattern for entire game
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);

    }
    public void GameOver()
    {
        //Enter game Over code
    }

    public void playerWin()
    {
        //Enter different scene
    }
    /*
     *  IEnumerator waitAndLoad()
    {
        yield return new WaitForSeconds(5f); //wait for load to happen

        SceneManager.LoadScene("VRMain"); //load scene

            //yield return new WaitForSeconds(.02f); //wait for load to happen

        }
     */
}

