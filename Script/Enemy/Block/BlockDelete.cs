using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDelete : MonoBehaviour
{

    public float gravitySpeedRateAdd = 15f;
    public float deleteAt = -10f;

    void Start()
    {
        //GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravitySpeedRateAdd;
        //Debug.Log(GetComponent<Rigidbody2D>().gravityScale);
    }

    void Update()
    {
        if (transform.position.y < deleteAt)
        {
            Destroy(gameObject);
        }
    }


}