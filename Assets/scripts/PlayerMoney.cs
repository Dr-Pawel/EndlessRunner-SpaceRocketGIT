using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public static PlayerMoney Instance;

    [SerializeField] public int currentMoney;

    public const string prefMoney = "prefMoney";

    private void Awake()
    {
        Instance = this;

        currentMoney = PlayerPrefs.GetInt(prefMoney);
    }

    public void AddMoney(int moneyToAdd)
    {
        currentMoney += moneyToAdd;
    }
    public int GetMoneyMadeAndSaveMoney()
    {
        int moneyMadeThisGame = currentMoney - PlayerPrefs.GetInt(prefMoney);
        PlayerPrefs.SetInt(prefMoney, currentMoney);

        return moneyMadeThisGame;
    }
}
