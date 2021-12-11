using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public BoxCollider2D collidernew;

    public Rigidbody2D rb;

    private float width;

    private float scrollSpeed = -6f;

    public GameObject asteroid;

    void Start()
    {
        collidernew = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collidernew.size.x;
        collidernew.enabled = false;

        rb.velocity = new Vector2(scrollSpeed, 0);
        ResetObstacle();
    }

    void Update()
    {
        if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
            ResetObstacle();
        }
    }

    void ResetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(0, Random.Range(-3, 3), 0);
    }

    
}
