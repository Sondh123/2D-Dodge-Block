using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockStatus : MonoBehaviour, IDDamageable
{
    Player targetCharacter;

    GameObject targetDestination;

    [SerializeField] int hpBlock = 3;

    [SerializeField] int dmg = 1;

    GameObject targetGameObject;

    private void Awake()
    {
        targetDestination = GameManager.instance.playerTransform.gameObject;
    }

    private void Start()
    {
        targetGameObject = targetDestination.gameObject;
    }
    public void TakeDameBlock(int dmg)
    {
        hpBlock -= dmg;
        if (hpBlock < 1)
        {           
            Destroy(gameObject);
            GetComponent<DropOnDestroy>().CheckDrop();
        }
    }

    private void Attack()
    {
        if (targetCharacter == null)
        {
            targetCharacter = targetGameObject.GetComponent<Player>();
        }       
        targetCharacter.TakeDamage(dmg);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameObject)
        {          
            Attack();
            Destroy(gameObject);
        }
    }
}
