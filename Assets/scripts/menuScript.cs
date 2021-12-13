using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class menuScript : MonoBehaviour
{
    public static menuScript Instance;

    public GameObject CanvasMain;
    public GameObject CanvasAch;
    public GameObject CanvasOpt;

    private void Awake()
    {
        Instance = this;
        
    }
    private void Update()
    {
        ShopManager.Instance.UpdateMoneyInMenu();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Gra Statek");
    }

    public void Achivements()
    {
        CanvasMain.SetActive(false);
        CanvasAch.SetActive(true);
    }

    public void Options()
    {
        CanvasMain.SetActive(false);
        CanvasOpt.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quiting ...");
    }

}
