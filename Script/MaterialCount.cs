using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCount : MonoBehaviour
{
    public int materialAccquired;
    [SerializeField] TMPro.TextMeshProUGUI materialCountText;

    public void Add(int count)
    {
        materialAccquired += count;
        materialCountText.text = "Materials: " + materialAccquired.ToString();
    }
}
