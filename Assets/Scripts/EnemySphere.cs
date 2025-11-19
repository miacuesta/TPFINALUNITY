using UnityEngine;

public class EnemySphere : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player"))
        {
            PlayerDeathHandler death = col.collider.GetComponent<PlayerDeathHandler>();
            if (death != null) death.PlayerDied();
        }
    }
}
