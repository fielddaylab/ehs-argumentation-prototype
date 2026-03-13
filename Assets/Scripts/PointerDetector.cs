using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerDetector : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private EvidenceBucket evidenceBucket;

    [SerializeField]
    private string evidenceHoverText;
    
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("I got hovered over!");
        evidenceBucket.SetText(evidenceHoverText);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("I got unhovered over!");
        evidenceBucket.ClearText();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
