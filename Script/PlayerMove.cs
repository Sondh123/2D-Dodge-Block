using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {
    public float speed = 150f; // tốc độ di chuyển trên bàn phím

    private Rigidbody2D rb;
    Transform player;
    public float mapWidth = 3.25f;
    public float mapLength = 8.0f; 
    // giới hạn chiều ngang, doc di chuyển của player tránh nó chạy ra khỏi màn hình

    public float MouseSpeed = 5f; // tốc độ di chuyển bằng chuột

    public float slowness = 10f; // slow motion khi player thua

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        player = GameManager.instance.playerTransform;
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        // use 'A' or 'D' or right/left arrow to move
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;

        //if (x == 0) {
        //    x = Input.GetAxis("Mouse X") * Time.fixedDeltaTime * speed * MouseSpeed; // use mouse to control
        //}

        Vector2 newPosition = rb.position + Vector2.right * x + Vector2.up * y;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        newPosition.y = Mathf.Clamp(newPosition.y, -mapLength, mapLength);
        rb.MovePosition(newPosition);

    }

    public void EndGame() {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel() {

        Time.timeScale = 1f / slowness; // khien time chay se giam tan toi 0.1 frame/s
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness; // de xu ly hinh anh duoc muot hon

        yield return new WaitForSeconds(2f / slowness);
        // luu y la khi xai timeScale se anh huong den waitForSeconds() 
        // vi vay phai chia cho so sloness de chay dung so second 

        Time.timeScale = 1f; // reset time ve bt
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness; // tra lai fixdeltaTime ban dau
        //ScrollerBackground lastInterval = new ScrollerBackground();
        //lastInterval.lastInterval = Time.realtimeSinceStartup;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}