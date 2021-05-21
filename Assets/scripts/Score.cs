using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TMP_Text newScore;
    public float scoreAmount;
    public float pointIncreasedPerSecond;

     void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 5f;
    }
    void Update()
    {
        newScore.text = "Score :" + (int)scoreAmount  ;
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    }
}
