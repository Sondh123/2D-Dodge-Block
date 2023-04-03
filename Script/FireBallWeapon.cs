using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallWeapon : MonoBehaviour
{
    [SerializeField] GameObject projectile;

    public float fireDelta = 0.25F;
    public int fireBallDmg = 1;

    public float spread = 0.25f;
    public int numberOfAttack = 3;
    
    private Vector2 attackSize = new Vector2(2f, 2f);

    private float nextFire ;
    private float myTime = 0.0F;

    PlayerMove playerMove;

    private void Awake()
    {
        playerMove = GetComponentInChildren<PlayerMove>();

    }
    private void Start()
    {
  
    }
    private void Update()
    {

        myTime = myTime + Time.deltaTime;
        if (Input.GetKey("space") && myTime > nextFire)
        {          
            nextFire = myTime + fireDelta;
            //newProjectile = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
            SpawnBullet();
            // create code here that animates the newProjectile

            nextFire = nextFire - myTime;
            myTime = 0.0F;
        }
    }

    private void SpawnBullet()
    {
        
        for (int i = 0; i < Player.numberOfAttack; i++)
        {
            GameObject Fire = Instantiate(projectile);

            Vector3 newFireBallPosition = transform.position;
            newFireBallPosition.x -= (Player.spread * Player.numberOfAttack) / 2; // calculating offset
            newFireBallPosition.x += i * Player.spread; //multi vu khi theo line

            Fire.transform.position = newFireBallPosition;

        }
    }

}
