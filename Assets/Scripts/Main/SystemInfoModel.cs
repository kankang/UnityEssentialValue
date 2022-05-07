using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public static class SystemInfoModel
{
    public static string GetInfo()
    {
        StringBuilder sb = new StringBuilder(10240);

        sb.Append("====================================\n");
        sb.Append("设备信息\n");
        sb.Append("====================================\n");
        sb.Append("设备型号").Append(':').Append(SystemInfo.deviceModel).Append('\n');
        sb.Append("操作系统").Append(':').Append(SystemInfo.operatingSystemFamily.ToString()).Append('\n');
        sb.Append("内存").Append(':').Append(SystemInfo.systemMemorySize).Append("M\n");
        sb.Append("设备名称（自定义）").Append(':').Append(SystemInfo.deviceName).Append('\n');
        sb.Append("设备类型").Append(':').Append(SystemInfo.deviceType).Append('\n');
        sb.Append("设备UID").Append(':').Append(SystemInfo.deviceUniqueIdentifier).Append('\n');

        sb.Append("====================================\n");
        sb.Append("CPU信息\n");
        sb.Append("====================================\n");
        sb.Append("CPU名称").Append(':').Append(SystemInfo.processorType).Append('\n');
        sb.Append("CPU数量").Append(':').Append(SystemInfo.processorCount).Append('\n');
        sb.Append("CPU频率").Append(':').Append(SystemInfo.processorFrequency).Append("MHz\n");


        sb.Append("====================================\n");
        sb.Append("GPU信息\n");
        sb.Append("====================================\n");
        sb.Append("GPU名称").Append(':').Append(SystemInfo.graphicsDeviceName).Append('\n');
        sb.Append("显存").Append(':').Append(SystemInfo.graphicsMemorySize).Append("M\n");
        sb.Append("GPU UID").Append(':').Append(SystemInfo.graphicsDeviceID).Append('\n');
        sb.Append("GPU API").Append(':').Append(SystemInfo.graphicsDeviceType.ToString()).Append('\n');
        sb.Append("GPU供应商").Append(':').Append(SystemInfo.graphicsDeviceVendor).Append('\n');
        sb.Append("GPU供应商ID").Append(':').Append(SystemInfo.graphicsDeviceVendorID).Append('\n');
        sb.Append("API类型和版本").Append(':').Append(SystemInfo.graphicsDeviceVersion).Append('\n');
        sb.Append("支持多线程渲染").Append(':').Append(SystemInfo.graphicsMultiThreaded).Append('\n');
        sb.Append("着色器级别").Append(':').Append(SystemInfo.graphicsShaderLevel).Append('\n');
        sb.Append("支持计算着色器").Append(':').Append(SystemInfo.supportsComputeShaders).Append('\n');
        sb.Append("支持GPU实例化").Append(':').Append(SystemInfo.supportsInstancing).Append('\n');
        sb.Append("支持内置阴影").Append(':').Append(SystemInfo.supportsShadows).Append('\n');
        sb.Append("支持阴影深度").Append(':').Append(SystemInfo.supportsRawShadowDepthSampling).Append('\n');
        sb.Append("支持复制纹理").Append(':').Append(SystemInfo.copyTextureSupport).Append('\n');
        sb.Append("支持Fence同步").Append(':').Append(SystemInfo.supportsGraphicsFence).Append('\n');
        sb.Append("支持光追").Append(':').Append(SystemInfo.supportsRayTracing).Append('\n');


        sb.Append("====================================\n");
        sb.Append("纹理支持\n");
        sb.Append("====================================\n");
        sb.Append("最大纹理").Append(':').Append(SystemInfo.maxTextureSize).Append('\n');
        sb.Append("NPOT").Append(':').Append(SystemInfo.npotSupport).Append('\n');
        sb.Append("纹理数量").Append(':').Append(SystemInfo.supportedRenderTargetCount).Append('\n');
        sb.Append("2D数组纹理").Append(':').Append(SystemInfo.supports2DArrayTextures).Append('\n');
        sb.Append("3D纹理").Append(':').Append(SystemInfo.supports3DTextures).Append('\n');
        sb.Append("稀疏纹理").Append(':').Append(SystemInfo.supportsSparseTextures).Append('\n');
        sb.Append("ASTC格式").Append(':').Append(SystemInfo.SupportsTextureFormat(TextureFormat.ASTC_4x4)).Append('\n');
        sb.Append("ASTC HDR格式").Append(':').Append(SystemInfo.SupportsTextureFormat(TextureFormat.ASTC_HDR_4x4)).Append('\n');
        sb.Append("ETC2格式").Append(':').Append(SystemInfo.SupportsTextureFormat(TextureFormat.ETC2_RGBA8)).Append('\n');
        sb.Append("DXT5格式").Append(':').Append(SystemInfo.SupportsTextureFormat(TextureFormat.DXT5)).Append('\n');
        sb.Append("PVRTC格式").Append(':').Append(SystemInfo.SupportsTextureFormat(TextureFormat.PVRTC_RGBA4)).Append('\n');


        sb.Append("====================================\n");
        sb.Append("硬件支持\n");
        sb.Append("====================================\n");
        sb.Append("加速计").Append(':').Append(SystemInfo.supportsAccelerometer).Append('\n');
        sb.Append("音频设备").Append(':').Append(SystemInfo.supportsAudio).Append('\n');
        sb.Append("陀螺仪").Append(':').Append(SystemInfo.supportsGyroscope).Append('\n');
        sb.Append("定位").Append(':').Append(SystemInfo.supportsLocationService).Append('\n');
        sb.Append("运动向量").Append(':').Append(SystemInfo.supportsMotionVectors).Append('\n');
        sb.Append("触摸震动").Append(':').Append(SystemInfo.supportsVibration).Append('\n');

        sb.Append("====================================\n");

        return sb.ToString();
    }
}
