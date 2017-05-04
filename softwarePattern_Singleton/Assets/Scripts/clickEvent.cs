using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickEvent : MonoBehaviour, IPointerClickHandler
{
    private singleton s;
    public void OnPointerClick(PointerEventData eventData)
    {
        singleton.Instance.SecondCounter();
    }
  

}
