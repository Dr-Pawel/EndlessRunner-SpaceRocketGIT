using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    

    [SerializeField] public static PlayerMoney Instance;

    [SerializeField] private int currentMoney;

    [SerializeField] public const string prefMoney = "prefMoney";

    private void Awake()
    {
        Instance = this;

        currentMoney = PlayerPrefs.GetInt(prefMoney);
    }

    public void AddMoney(int moneyToAdd)
    {
        currentMoney += moneyToAdd;
        
    }

   
    public void AddMoneyAndSave(int moneyToAdd)
    {
        currentMoney += moneyToAdd;
        PlayerPrefs.SetInt(prefMoney, currentMoney);
    }

    public int GetMoneyMadeAndSaveMoney()
    {
        int moneyMadeThisGame = currentMoney - PlayerPrefs.GetInt(prefMoney);
        PlayerPrefs.SetInt(prefMoney, currentMoney);

        return moneyMadeThisGame;       
    }

    public int ReturnCurrentMoney()
    {
        return currentMoney;
    }

    public bool TryRemoveMoney(int moneyToRemove)
    {
        if (currentMoney >= moneyToRemove)
        {
            currentMoney -= moneyToRemove;
            return true;
        }   
        else
        {
            return false;
        }
    }
}
