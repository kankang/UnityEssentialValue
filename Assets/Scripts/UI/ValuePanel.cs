using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValuePanel : PanelBase
{
    public Text title;
    public Text content;

    public void SetContent(string title, string content)
    {
        this.title.text = title;
        this.content.text = content;
    }
}
