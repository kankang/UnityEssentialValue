using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePanel : PanelBase
{
    public ValuePanel valuePanel;

    public void OnClickPanelClose()
    {
        Show();
        valuePanel.Close();
    }

    public void OnClickSystemInfoBtn()
    {
        Close();
        valuePanel.Show();
        valuePanel.SetContent("SystemInfo", SystemInfoModel.GetInfo());
    }

    public void OnClickPathBtn()
    {
        Close();
        valuePanel.Show();
        valuePanel.SetContent("Path", PathInfoModel.GetInfo());
    }
}
