using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{
    public GameObject text;
    private Image img;
   public enum AchievementTypes { ReachDistance1, ReachDistance2, ReachDistance3}
   [SerializeField] private AchievementTypes achievementType;
   public AchievementTypes _achievementType { get { return achievementType; } }

    public bool isUnlocked { get; private set; }

    private void Awake()
    {
        
        img = GetComponent<Image>();
        CheckIfAchievementIsUnlocked();
    }

    public void CheckIfAchievementIsUnlocked()
    {
        if(PlayerPrefs.GetInt(achievementType.ToString()) == 0)
        {
            img.color = Color.black;
        }
        else
        {
            text.SetActive(false);
            img.color = Color.white;
            isUnlocked = true;
        }
    }

    public void  UnlockThisAchievement()
    {
        PlayerPrefs.SetInt(achievementType.ToString(), 1);
        Awake();
    }
    
    
}
