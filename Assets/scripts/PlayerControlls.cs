using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControlls : MonoBehaviour
{

    public GameObject canves;
    [SerializeField] private TMP_Text GameOver;
   [SerializeField] private TMP_Text GemsText;
    public Rigidbody2D rb;
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(0, moveDirection * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Obstacle" ))
        {
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
            PlayerMoney.Instance.AddMoney(1);
            other.gameObject.SetActive(false);
        }

    }
}
