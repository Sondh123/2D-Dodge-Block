using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScale : MonoBehaviour
{
    [SerializeField] float gravityScale = 1;
    float gravityScale2, gravityScale3, gravityScale4;

    // Start is called before the first frame update
    void Start()
    {
        gravityScale2 = gravityScale * 2;
        gravityScale3 = gravityScale2 * 2;
        gravityScale4 = gravityScale3 * 2;
    }
    // Update is called once per frame
    void Update()
    {
        float timeNow = Time.timeSinceLevelLoad;
        if (timeNow > 30)
        {
            GetComponent<Rigidbody2D>().gravityScale = gravityScale2;
        }
        if (timeNow > 100)
        {
            GetComponent<Rigidbody2D>().gravityScale = gravityScale3;
         
        }
        if (timeNow > 500)
        {
            GetComponent<Rigidbody2D>().gravityScale = gravityScale4;
        }
    }
}
