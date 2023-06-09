using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TImeCount : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float time;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTime(float time)
    {

        int minutes = (int)(time / 60f);
        int seconds = (int)(time % 60f);

        text.text = minutes.ToString() + ":" + seconds.ToString("00");

    }
    private void Update()
    {
        time += Time.deltaTime;
        UpdateTime(time);
    }

}