using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBase : MonoBehaviour
{
    public void Show()
    {
        ((RectTransform)transform).anchoredPosition = Vector2.zero;
    }

    public void Close()
    {
        ((RectTransform)transform).anchoredPosition = Vector2.negativeInfinity;
    }
}
