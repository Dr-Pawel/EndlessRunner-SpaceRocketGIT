using UnityEngine;

public class SkinLoader : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerSR;

    private void Awake()
    {
        
        playerSR.sprite = SkinManager.equippedSkin;
        playerSR.size = new Vector2(11f,13f);
    }
}
