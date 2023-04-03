using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player c = collision.GetComponent<Player>();
        if (c != null)
        {
            GetComponent<IPickUpObject>().OnPickUp(c);
            Debug.Log("da nhat");
            Destroy(gameObject);
        }
    }

}
