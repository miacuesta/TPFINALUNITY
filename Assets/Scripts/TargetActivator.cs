using UnityEngine;

public class TargetActivator : MonoBehaviour
{
    [Header("LUZ QUE REVELA LA PLATAFORMA")]
    public Light revealLight;

    [Header("RENDERER DE LA DIANA (SE ILUMINA)")]
    public Renderer dianaRenderer;

    [Header("MATERIALES")]
    public Material DianaOff;
    public Material DianaOn;

    private bool activated = false;

    public void Activate()
    {
        if (activated) return; // evita que se reactive mil veces
        activated = true;

        // Cambiar el material a DianaOn (emisivo)
        if (dianaRenderer != null && DianaOn != null)
        {
            dianaRenderer.material = DianaOn;
        }

        // Encender luz de la plataforma
        if (revealLight != null)
        {
            revealLight.enabled = true;
        }

        Debug.Log("DIANA ACTIVADA");
    }
}
