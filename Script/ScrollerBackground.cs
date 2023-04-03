using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameManager;

public class ScrollerBackground : MonoBehaviour
{
    public float speed = 0.1f;   //tốc độ scrolling
    private Material mat;    // khởi tạo một biến Material
    private Vector2 offset = Vector2.zero;   //khai báo 1 độ dời cho background
    


    // Start is called before the first frame update
    void Start()
        {
            
            mat = GetComponent<Renderer>().material;   //khởi tạo material
            offset = mat.GetTextureOffset("__MainTex");

        }

        // Update is called once per frame
    void Update()
    {
        float timeNow = Time.timeSinceLevelLoad;
        offset.y += speed * Time.deltaTime;   // cho background di chuyển từ trên xuống nê ta lấy trục y (nếu muốn di chuyển sang ngang thì ta lấy trục x)
        mat.SetTextureOffset("_MainTex", offset);

        if (timeNow > 30)
        {
            speed = 0.2f;
        }
        if (timeNow > 90)
        {
            speed = 0.3f;
        }
        if (timeNow > 130)
        {
            speed = 0.4f;
        }
        if (timeNow > 200)
        {
            speed = 0.5f;
        }
       
    }
}

//mục đích 2 câu lệnh "mat.GetTextureOffset("__MainTex")" và "mat.SetTextureOffset("_MainTex", offset)" là tạo sự lặp lại vô tận cho background scorlling di chuyển xuống.