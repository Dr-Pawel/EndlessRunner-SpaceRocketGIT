using UnityEngine;

public class GameManager : MonoBehaviour
{   
    bool gameHasEnded = false;
    public GameObject RestartUI;
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            RestartUI.SetActive(true);
            Debug.Log("GAME OVER");
           
        }   
    }      
}
