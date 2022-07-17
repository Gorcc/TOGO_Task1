using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public CollectScript collectScript;
    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject wPlayer;
    public GameObject lPlayer;
    public GameObject cPlayer;
    public PlayerMovement playerMovement;


    void Update()
    {
        if(collectScript.score >= 10)
        {
            cPlayer.SetActive(false);
            wPlayer.SetActive(true);
            playerMovement.forwardForce = 0f;
            playerMovement.horizontalForce = 0f;
            winScreen.SetActive(true);
        }

        else if(collectScript.score < 0)
        {
            cPlayer.SetActive(false);
            lPlayer.SetActive(true);
            playerMovement.forwardForce = 0f;
            playerMovement.horizontalForce = 0f;
            loseScreen.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
