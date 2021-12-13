using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SkinInShop : MonoBehaviour
{
   // [SerializeField] private Image skinImage;
    [SerializeField] private SSkinInfo skinInfo;
    public SSkinInfo _skinInfo { get { return skinInfo; } }

    [SerializeField] private bool IsskinUnlocked;  //SFD  
    [SerializeField] private bool IsFreeSkin;

    [SerializeField] private TextMeshProUGUI buttonText;
 
    private void Awake()
    {
        if(IsFreeSkin)
        {
            PlayerMoney.Instance.TryRemoveMoney(0);           
            PlayerPrefs.SetInt(skinInfo._skinID.ToString(), 1);
            
        }

     //   skinImage.sprite = skinInfo._skinSprite;
        IsSkinUnlocked();
    }

    private void Start()
    {
        ShopManager.Instance.UpdateMoneyInSHopUI();
    }

    private void Update()
    {
        ShopManager.Instance.UpdateMoneyInSHopUI();
    }

    private void IsSkinUnlocked()
    {
        if (PlayerPrefs.GetInt(skinInfo._skinID.ToString()) == 1)
        {
            IsskinUnlocked = true;
            buttonText.text = "Equip";
        }
        else
        {
            buttonText.text = "Buy:" + skinInfo._skinPrice;
        }
       
    }

    public void OnButtonPress()
    {
        if(IsskinUnlocked)
        {
            SkinManager.Instance.EquipSkin(skinInfo);
        }
        else
        {
            //buy
           if (PlayerMoney.Instance.TryRemoveMoney(skinInfo._skinPrice))
            {
                
                PlayerPrefs.SetInt(skinInfo._skinID.ToString(), 1);
                IsSkinUnlocked();
               
            }
        }
       
        ShopManager.Instance.UpdateMoneyInSHopUI();
    }

}


