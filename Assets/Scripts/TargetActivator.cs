using UnityEngine;

public class TargetActivator : MonoBehaviour
{
    [Header("LUZ QUE REVELA LA PLATAFORMA")]
    public Light revealLight;

    [Header("RENDERER DE LA DIANA (SE ILUMINA)")]
    public Renderer dianaRenderer;

    public void Activate()
    {
        // Activar emisiones en la DIANA
        if (dianaRenderer != null)
        {
            dianaRenderer.material.EnableKeyword("_EMISSION");
        }

        // Encender la luz encima de la plataforma
        if (revealLight != null)
        {
            revealLight.enabled = true;
        }

        Debug.Log("DIANA ACTIVADA");
    }
}
