using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public SpriteRenderer ArmorRenderer;
    public SpriteRenderer WeaponRenderer;
    public UnityEngine.UI.Button WeaponShopButton;
    public UnityEngine.UI.Button ArmorShopButton;

    public void SetArmor(Sprite newSprite)
    {
        this.WeaponShopButton.SetActive(false);
        this.ArmorShopButton.SetActive(true);
        ArmorRenderer.sprite = newSprite;

    }


    public void SetWeapon(Sprite newSprite)
    {
        this.WeaponShopButton.SetActive(true);
        this.ArmorShopButton.SetActive(false);
        WeaponRenderer.sprite = newSprite;
    }


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
