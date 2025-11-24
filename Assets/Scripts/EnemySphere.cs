using UnityEngine;

public class EnemySphere : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        // Si golpea DIANA
        TargetActivator target = col.collider.GetComponent<TargetActivator>();
        if (target != null)
        {
            target.Activate();
            return;
        }

        // Si golpea PLAYER
        if (col.collider.CompareTag("Player"))
        {
            PlayerDeathHandler death = col.collider.GetComponent<PlayerDeathHandler>();
            if (death != null)
            {
                death.PlayerDied();
            }
        }
    }
}
