using UnityEngine;

public class TargetActivator : MonoBehaviour
{
    public Light revealLight;
    public Renderer rend;

    public void Activate()
    {
        rend.material.EnableKeyword("_EMISSION");
        revealLight.enabled = true;
    }
}
