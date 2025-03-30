using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverText : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject textHover;

    private void Start()
    {
        textHover.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        textHover.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textHover.SetActive(false);
    }
}
