using UnityEngine;

public class Gun : MonoBehaviour
{
    public Camera playerCam;          // La cámara del jugador
    public Transform muzzlePoint;     // Desde donde sale la esfera
    public GameObject enemySpherePrefab; // Prefab de la esfera enemiga
    public float shootForce = 400f;
    public float rayDistance = 100f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireRaycast();
            SpawnSphere();
        }
    }

    void FireRaycast()
    {
        Ray ray = new Ray(playerCam.transform.position, playerCam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            // Si golpea una diana
            TargetActivator target = hit.collider.GetComponent<TargetActivator>();
            if (target != null)
            {
                target.Activate();
                return;
            }

            // Si golpea un rigidbody → AddForce
            Rigidbody rb = hit.collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(ray.direction * shootForce);
            }
        }
    }

    void SpawnSphere()
    {
        GameObject sphere = Instantiate(enemySpherePrefab, muzzlePoint.position, Quaternion.identity);
        Rigidbody rb = sphere.GetComponent<Rigidbody>();
        rb.AddForce(playerCam.transform.forward * shootForce);
    }
}
