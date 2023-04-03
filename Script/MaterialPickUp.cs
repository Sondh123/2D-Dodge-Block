using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialPickUp : MonoBehaviour,IPickUpObject
{
    [SerializeField] int count;
    public void OnPickUp(Player player)
    {
        player.material.Add(count);
    }
}
