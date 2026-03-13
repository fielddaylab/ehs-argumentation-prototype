using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeline : MonoBehaviour
{
    [SerializeField] private Slider timeIndicator;
    public int time = 1;
    

    public void ChangeTime(int i)
    {
        time = Mathf.Clamp(time + i, 1, 8);
        timeIndicator.value = time - 1;

    }
}
