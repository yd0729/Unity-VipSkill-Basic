using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class L4_15_Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        print($"OnBeginDrag {eventData}");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print($"OnEndDrag {eventData}");
    }

    public void OnDrag(PointerEventData eventData)
    {
        print($"OnDrag {eventData}");
    }
}
