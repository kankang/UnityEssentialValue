using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public static class PathInfoModel
{
    public static string GetInfo()
    {
        StringBuilder sb = new StringBuilder(10240);

        sb.Append("====================================\n");
        sb.Append("dataPath\n");
        sb.Append(Application.dataPath).Append('\n');

        sb.Append("====================================\n");
        sb.Append("persistentDataPath\n");
        sb.Append(Application.persistentDataPath).Append('\n');

        sb.Append("====================================\n");
        sb.Append("streamingAssetsPath\n");
        sb.Append(Application.streamingAssetsPath).Append('\n');

        sb.Append("====================================\n");
        sb.Append("temporaryCachePath\n");
        sb.Append(Application.temporaryCachePath).Append('\n');

        sb.Append("====================================\n");
        sb.Append("consoleLogPath\n");
        sb.Append(Application.consoleLogPath).Append('\n');


        sb.Append("====================================\n");

        return sb.ToString();
    }
}
