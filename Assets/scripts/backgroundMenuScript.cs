using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMenuScript : MonoBehaviour
{
    public BoxCollider2D collidernew;

    public Rigidbody2D rb;

    private float width;

    public float scrollSpeed;

  
    public GameObject asteroid;

    void Start()
    {
        scrollSpeed = -8f;

        collidernew = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collidernew.size.x;
        collidernew.enabled = false;

        ResetObstacle();
        
    }

    void Update()
    {
  
        rb.velocity = new Vector2(scrollSpeed, 0);

        if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
            ResetObstacle();
            
        }

    }

    void ResetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(Random.Range(4, 7), Random.Range(-3, 3), 0);
    }

   


}
