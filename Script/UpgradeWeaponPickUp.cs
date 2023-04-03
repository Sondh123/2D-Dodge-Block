using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWeaponPickUp : MonoBehaviour,IPickUpObject
{
    
    public void OnPickUp(Player player)
    {
        Debug.Log("levelPickUPObject");
        player.levelUp();
    }
}
