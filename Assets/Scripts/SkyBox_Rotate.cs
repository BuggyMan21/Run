using UnityEngine;

public class SkyBox_Rotate : MonoBehaviour
{
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 1.2f);
    }
}
