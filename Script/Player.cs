using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHp = 100;
    public int currentHp = 100;
    public int armor = 0;
    [SerializeField] HealthBar hpBar;

    private bool isDead;

    public static int numberOfAttack = 1;
    public static float spread = 0.25f;

    [HideInInspector] public MaterialCount material;


    private void Awake()
    {
        material = GetComponent<MaterialCount>();
    }
    public void Start()
    {
        hpBar.SetState(currentHp, maxHp);
    }

    public void TakeDamage(int damage)
    {
        if (isDead == true)
        {
            return;
        }

        
        //ApplyArmor(ref damage);

        currentHp -= damage;
        FindObjectOfType<SoundManager>().Play("TakeDame");

        if (currentHp <= 0)
        {
            currentHp = 0;
            isDead = true;
            FindObjectOfType<SoundManager>().Play("Death");
            GetComponent<PlayerGameOver>().GameOver();
            
        }
        hpBar.SetState(currentHp, maxHp);
    }


    private void ApplyArmor(ref int damage)
    {
        damage -= armor;
        if (damage < 0)
        {
            damage = 0;
        }
    }

    public void levelUp()
    {
        numberOfAttack += 1;
        spread += 0.05f;
    }

    public void Heal(int amount)
    {
        if (currentHp <= 0)
        {
            currentHp = 0 + amount;
            Debug.Log("Da hoi mau");
        }
        Debug.Log("Da hoi mau");
        currentHp += amount;
        if (currentHp > maxHp)
        {
            currentHp = maxHp;
        }
        hpBar.SetState(currentHp, maxHp);
    }


    
}

