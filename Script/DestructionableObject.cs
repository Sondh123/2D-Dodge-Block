using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionableObject : MonoBehaviour, IDDamageable
{
    public void TakeDameBlock(int dmg)
    {
        Debug.Log("da pha huy");
        Destroy(gameObject);
        GetComponent<DropOnDestroy>().CheckDrop();
    }
}
