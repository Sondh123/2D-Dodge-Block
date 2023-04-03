// Instantiates a projectile every 0.5 seconds,
// if the Fire1 button (default is Ctrl) is pressed.

using UnityEngine;
using System.Collections;

public class FireBallSpawner : MonoBehaviour
{

    Vector3 direction;
    //[SerializeField] float speed;
    [SerializeField] int damage = 1;

    public void SetDirection(float dir_x, float dir_y)
    {
        direction = new Vector3(dir_x, dir_y);
        if (dir_x < 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
            transform.localScale = scale;
        }
    }
    bool hitDetected = false;
    private void Update()
    {
        if (Time.frameCount % 6 == 0)
        {
            //transform.position += direction * speed * Time.deltaTime;
            Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, 0.7f); //tnag kich thuoc
            foreach (Collider2D c in hit)
            {
                BlockStatus enemy = c.GetComponent<BlockStatus>();
                if (enemy != null)
                {
                    hitDetected = true;                
                    enemy.TakeDameBlock(damage);                    
                    break;
                }
            }
            if (hitDetected == true)
            {               
                Destroy(gameObject);
            }
        }
    }
}