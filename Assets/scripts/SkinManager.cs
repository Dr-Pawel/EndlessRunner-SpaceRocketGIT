using UnityEngine;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine.UI;

public class SkinManager : MonoBehaviour
{
    public static Sprite equippedSkin { get; private set; }

    public static SkinManager Instance;

    [SerializeField] private SSkinInfo[] allSkins;

    private const string skinPref = "skinPref";

    [SerializeField] private Transform skinsInShopPanelsParent;
    [SerializeField] private List<SkinInShop> skinsInShopPanels = new List<SkinInShop>();//SFD

    private void Awake()
    {
        Instance = this;

        EquipPreviousSkin();
        foreach (Transform s in skinsInShopPanelsParent)
        {
            if (s.TryGetComponent(out SkinInShop skinInShop))
                skinsInShopPanels.Add(skinInShop);

           // SkinInShop SkinEquippedPanel = Array.Find(skinsInShopPanels.ToArray(), dummyFind => dummyFind._skinInfo._skinSprite == equippedSkin);
           // SkinEquippedPanel.GetComponentInChildren<Button>().interactable = false;
            

        }

        Instance = this;


        
    }
    private void EquipPreviousSkin()
    {
        string lastSkinUsed = PlayerPrefs.GetString(skinPref, SSkinInfo.SkinIDs.def.ToString());
        SSkinInfo SkinUsedLastTime = Array.Find(allSkins, dummyFind => dummyFind._skinID.ToString() == lastSkinUsed);
        EquipSkin(SkinUsedLastTime);
    }

    public void EquipSkin(SSkinInfo skinInfo)
    {
        equippedSkin = skinInfo._skinSprite;
        PlayerPrefs.SetString(skinPref ,skinInfo._skinID.ToString());
    }
}
