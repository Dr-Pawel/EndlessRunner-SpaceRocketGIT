using UnityEngine;

public class rotateObstacle : MonoBehaviour
{
        void Update()
        {
            transform.Rotate(0, 0,100 * Time.deltaTime); //rotates 50 degrees per second around z axis
        }
    
}
