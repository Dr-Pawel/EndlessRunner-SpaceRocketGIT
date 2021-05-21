using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlls : MonoBehaviour
{
    public GameObject canves;
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
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
