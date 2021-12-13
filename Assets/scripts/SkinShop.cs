using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkinShop : MonoBehaviour
{
    public SSkinInfo skinInfo;

    public bool isSkinUnlocked;

    public TextMeshProUGUI buttonText;

    private void Awake()
    {
        IsSkinUnlocked();
   
    }

    private void IsSkinUnlocked()
    {
        if (PlayerPrefs.GetInt(skinInfo._skinID.ToString()) == 1)
        {
            isSkinUnlocked = true;
            buttonText.text = ("EQUIP");

        }
    }

    public void OnButtonPress()
    {
        if(isSkinUnlocked)
        {
            //equip
        }
        else
        {
            //buy
           if(FindObjectOfType<PlayerMoney>().TryRemoveMoney(skinInfo._skinPrice))
            {
                PlayerPrefs.SetInt(skinInfo._skinID.ToString(), 1);
                IsSkinUnlocked();
            }
        }
    }
    

}
