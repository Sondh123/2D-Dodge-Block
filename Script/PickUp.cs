using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player c = collision.GetComponent<Player>();
        Debug.Log("da tim thay health");
        if (c != null)
        {
            GetComponent<IPickUpObject>().OnPickUp(c);
            Debug.Log("da nhat");
            Destroy(gameObject);
        }
    }


}
