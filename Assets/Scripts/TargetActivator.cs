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

    [Header("PLATAFORMAS A ACTIVAR")]
    public GameObject[] plataformas; // ← plataformas que se activan

    private bool activated = false;

    public void Activate()
    {
        if (activated) return; // evita reactivaciones
        activated = true;

        // Cambiar material de la diana
        if (dianaRenderer != null && DianaOn != null)
            dianaRenderer.material = DianaOn;

        // Encender luz
        if (revealLight != null)
            revealLight.enabled = true;

        // Activar cada plataforma
        foreach (GameObject p in plataformas)
        {
            if (p != null)
                p.SetActive(true);
        }

        Debug.Log("DIANA ACTIVADA + PLATAFORMAS ACTIVADAS");
    }
}
