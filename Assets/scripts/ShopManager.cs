using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{
    [SerializeField]public static ShopManager Instance;


    [SerializeField] private TextMeshProUGUI moneyInShopText;
    [SerializeField] private TextMeshProUGUI moneyInShopMenu;

    private void Awake()
    {
        Instance = this;  
    }

    private void Start()
    {
        UpdateMoneyInMenu();
        UpdateMoneyInSHopUI();
    }
    public void UpdateMoneyInSHopUI()
    {
        moneyInShopText.text = PlayerMoney.Instance.ReturnCurrentMoney() + "";
    }
    public void UpdateMoneyInMenu()
    {
        moneyInShopMenu.text = PlayerMoney.Instance.ReturnCurrentMoney() + "";
    }
}
