using UnityEngine;
using UnityEngine.SceneManagement;

public class resetUI : MonoBehaviour
{
   public void Restart()
    {
        SceneManager.LoadScene("Gra Statek");
        Time.timeScale = 1f;
    }
   public  void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
