using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvidenceBucket : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI BucketText = null;

    public void SetText(string text)
    {
        BucketText.text = text;
    }

    public void ClearText()
    {
        BucketText.text = "<i>evidence bucket</i>";
    }
}
