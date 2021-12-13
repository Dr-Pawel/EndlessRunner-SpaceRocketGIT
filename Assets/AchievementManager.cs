using UnityEngine;
using System;
using System.Collections.Generic;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager Instance;

    

    [SerializeField] private Achievement[] trophies;

    private void Awake()
    {
        Instance = this;
    }

    public void UnlockAchievement(Achievement.AchievementTypes achievementType)
    {
        Achievement achievementToUnlock = Array.Find(trophies, dummyTrophy => dummyTrophy._achievementType == achievementType);

        if(achievementToUnlock == null)
        {
            Debug.LogWarning("Trophy Not added with achievemtn: " + achievementToUnlock);
            return;
        }

        if(!achievementToUnlock.isUnlocked)        
            achievementToUnlock.UnlockThisAchievement();
        
        
    }
    

}
