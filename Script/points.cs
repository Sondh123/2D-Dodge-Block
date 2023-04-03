using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class points :MonoBehaviour
{
    TImeCount imeCount;
    [SerializeField] TextMeshProUGUI text2;
    private float time2;
    // Start is called before the first frame update
    private void Awake()
    {
        text2 = GetComponent<TextMeshProUGUI>();
        imeCount = FindObjectOfType<TImeCount>();
    }
    void Start()
    {
        time2 = imeCount.time;
        UpdateTime(time2);
       
    }
    public void UpdateTime(float time)
    {

        int minutes = (int)(time / 60f);
        int seconds = (int)(time % 60f);

        text2.text = minutes.ToString() + ":" + seconds.ToString("00");

    }
}
