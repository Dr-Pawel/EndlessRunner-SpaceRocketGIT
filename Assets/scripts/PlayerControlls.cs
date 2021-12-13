using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControlls : MonoBehaviour
{

    public GameObject canves;
    [SerializeField] private TMP_Text GemsGame;  
    [SerializeField] private TMP_Text GameOver;
    [SerializeField] private TMP_Text GemsText;

    public GameObject GemsObj;
    public Rigidbody2D rb;

    
    public float moveSpeed = 20;

    bool DefaultSeleted;
    bool FirstSelected;
    bool secoundSelected;

    public GameObject Default, First, Secound;
    // Start is called before the first frame update
    void Start()
    {
        DefaultSeleted = SelectSkin.DefaultSelected;
        FirstSelected = SelectSkin.SkinFirstSelected;
        secoundSelected = SelectSkin.SkinSecoundSelected;

        if(DefaultSeleted == true)
        {
            Default.SetActive(true);
            First.SetActive(false);
            Secound.SetActive(false);
        }
        if(FirstSelected == true)
        {
            Default.SetActive(false);
            First.SetActive(true);
            Secound.SetActive(false);           
        }
        if(secoundSelected == true)
        {
            Default.SetActive(false);
            First.SetActive(false);
            Secound.SetActive(true);
        }

        rb = GetComponent<Rigidbody2D>();
        GemsObj.SetActive(true);
       
    }

    // Update is called once per frame
    void Update()
    {

        movement();

        GemsGame.text = PlayerMoney.Instance.ReturnCurrentMoney() + "";
    }

    public void movement()
    {
        
        float moveDirection = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(0, moveDirection * moveSpeed);
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Obstacle" ))
        {
            
            GemsObj.SetActive(false);

            Time.timeScale = 0f; 
           bool isNewHighscore =  Score.Instance.CheckNewHighscore();
            if(isNewHighscore )
            {
                GameOver.text = "New HighScore!!!";
            }
 
            int moneyMadeThisGame = PlayerMoney.Instance.GetMoneyMadeAndSaveMoney();
            GemsText.text = "Gems: " + moneyMadeThisGame;

            FindObjectOfType<GameManager>().EndGame();
        }
        if ((other.gameObject.CompareTag("collectibles")))
        {
            PlayerMoney.Instance.AddMoney(3000);
            other.gameObject.SetActive(false);
        }

    }
}
