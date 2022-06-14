using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class L4_15_Point : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{

    public void OnPointerUp(PointerEventData eventData)
    {
        print($"OnPointerUp {eventData}");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        print($"OnPointerDown {eventData}");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print($"OnPointerClick {eventData}");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print($"OnPointerEnter {eventData}");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print($"OnPointerExit {eventData}");
    }


}
