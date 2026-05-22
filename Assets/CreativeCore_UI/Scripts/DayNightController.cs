using UnityEngine;
using UnityEngine.Rendering;
using Light = UnityEngine.Light;

public class DayNightController : MonoBehaviour
{
    public Light directionalLight;
    public Material daySkybox;
    public Material nightSkybox;
    public Light fireLight;

    public void SetDay()
    {
        RenderSettings.skybox = daySkybox;
        directionalLight.intensity = 1f;
        directionalLight.colorTemperature = 6570;
        DynamicGI.UpdateEnvironment();
    }

    public void SetNight()
    {
        RenderSettings.skybox = nightSkybox;
        directionalLight.intensity = 0.1f;
        directionalLight.colorTemperature = 4000;
        DynamicGI.UpdateEnvironment();
    }

    public void SetFireBrightness(float value)
    {
        fireLight.intensity = value;
    }
}