using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class menuScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject CanvasMain;
    public GameObject CanvasAch;
    public GameObject CanvasOpt;
    public GameObject InGameUI;
    public TMP_Text GemsMenu;


    public void Start()
    {
        GemsMenu.text = PlayerMoney.Instance.currentMoney.ToString();
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
    }

}
