using UnityEngine;
using TMPro;
using System.IO;

public class SelectSkin : MonoBehaviour

{
    [SerializeField]private TMP_Text GemsMenu;
    [SerializeField] private TMP_Text PriceTag1;
    [SerializeField] private TMP_Text PriceTag2;
    [SerializeField] private TMP_Text priceTagDefualt;

    public UnlockableMatrix unlockableMatrix;

    public static bool DefaultSelected;
    public static bool SkinFirstSelected;
    public static bool SkinSecoundSelected;
 
    public GameObject CostShip1;
    public GameObject CostShip2;

    private string unlockMatrixPath;
    

   private void Start()
    {
        GemsMenu.text = PlayerMoney.Instance.ReturnCurrentMoney() + "";

        UpdateMoneyInShop();
    }
    
    private void UpdateMoneyInShop()
    {  
        GemsMenu.text = PlayerMoney.Instance.ReturnCurrentMoney() + "";
    }

    public void BuySkin1()
    {  
        if(PlayerMoney.Instance.ReturnCurrentMoney() >= 300)
        {
            unlockableMatrix.Ship1IsBought = true;
            PlayerMoney.Instance.AddMoneyAndSave(-300);
            UpdateMoneyInShop();         
            if (unlockableMatrix.Ship1IsBought == true)
            {
                SkinFirstSelected = true;
                DefaultSelected = false;
                SkinSecoundSelected = false;
                CostShip1.SetActive(false);

                
                PriceTag1.text = ("IN USE");               
                priceTagDefualt.text = ("UNLOCKED");
               
            }
            if (unlockableMatrix.Ship2IsBought == true)
            {
                PriceTag2.text = ("UNLOCKED");
            }
        }
        else if (PlayerMoney.Instance.ReturnCurrentMoney() <= 300)
        {
            PlayerMoney.Instance.AddMoneyAndSave(-0);
            unlockableMatrix.Ship1IsBought = false;
            Debug.Log("not enough money");
        }
        if (unlockableMatrix.Ship1IsBought == true)
        {
            PlayerMoney.Instance.AddMoneyAndSave(+300);
            unlockableMatrix.Ship1IsBought = false;
            Debug.Log("YOU ALREADY HAVE THIS SHIP");
        }
    }

    public void BuySkin2()
    {
        if (PlayerMoney.Instance.ReturnCurrentMoney() >= 200)
        {
            PlayerMoney.Instance.AddMoneyAndSave(-200);
            UpdateMoneyInShop();
            unlockableMatrix.Ship2IsBought = true;
            if (unlockableMatrix.Ship2IsBought == true)
            {
                SkinSecoundSelected = true;
                SkinFirstSelected = false;
                DefaultSelected = false;                                              
                CostShip2.SetActive(false);
                
                PriceTag2.text = ("IN USE");               
                priceTagDefualt.text = ("UNLOCKED");
            }        
            if(unlockableMatrix.Ship1IsBought == true)
            {
                PriceTag1.text = ("UNLOCKED");
            }
        }    
        else if (PlayerMoney.Instance.ReturnCurrentMoney() <=200)
        {
            PlayerMoney.Instance.AddMoneyAndSave(-0);
            unlockableMatrix.Ship2IsBought = false;
            Debug.Log("not enough money");
        }
        if(unlockableMatrix.Ship2IsBought == true)
        {
            PlayerMoney.Instance.AddMoneyAndSave(+200);
            unlockableMatrix.Ship2IsBought = false;
            Debug.Log("YOU ALREADY HAVE THIS SHIP");
        }
    }
   
    public void skinSelection1()
    {
 
        if(unlockableMatrix.Ship1IsBought == true)
        {
            SkinFirstSelected = true;
            DefaultSelected = false;
            SkinSecoundSelected = false;
            
        }   
        else if(unlockableMatrix.Ship1IsBought == false)
        {
            SkinFirstSelected = false;
            DefaultSelected = true;
            SkinSecoundSelected = false;
         
        }
    }
    public void skinSelection2()
    {
        if (unlockableMatrix.Ship1IsBought == true)
        {
            SkinFirstSelected = false;
            DefaultSelected = false;
            SkinSecoundSelected = true;   
        }
    }

      public void SelectDefault()
      {
        unlockableMatrix.defaultShipIsBought = true;
        if (unlockableMatrix.defaultShipIsBought == true)
        {
            DefaultSelected = true;
            SkinFirstSelected = false;
            SkinSecoundSelected = false;
            priceTagDefualt.text = ("IN USE");
            if(unlockableMatrix.Ship1IsBought == true)
            {
                PriceTag1.text = ("UNLOCKED");
            }
            else
            {
                PriceTag1.text = ("BUY");
            }
            if(unlockableMatrix.Ship2IsBought == true)
            {
                PriceTag2.text = ("UNLOCKED");
            }
            else
            {
                PriceTag2.text = ("BUY");
            }
            
        }
        
    }

}
