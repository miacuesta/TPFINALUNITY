using UnityEngine;

public class NPCHealth : MonoBehaviour
{
    public float healthPoints = 1f;     // Muere de 1 golpe
    public float destroyTime = 0.2f;    // Tiempo antes de respawnear o morir
    public bool respawnOnDeath = true;  // Si querés respawn

    private NPCSpawner respawn;      // Script opcional que hará el respawn

    void Awake()
    {
        respawn = GetComponent<NPCSpawner>();
    }

    public void TakeDamage(float damage)
    {
        healthPoints -= damage;

        if (healthPoints <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        Debug.Log("PLAYER DIED");

        // Deshabilitar movimiento (si tu script se llama CharacterController / FirstPerson / etc)
        MonoBehaviour movement = GetComponent<MonoBehaviour>();
        if (movement != null) movement.enabled = false;

        if (respawnOnDeath && respawn != null)
        {
            respawn.RespawnPlayer();
        }
        else
        {
            Destroy(gameObject, destroyTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        DamageOnCollision damage = collision.gameObject.GetComponent<DamageOnCollision>();
        if (damage)
        {
            TakeDamage(damage.damagePoints);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        DamageOnCollision damage = other.GetComponent<DamageOnCollision>();
        if (damage)
        {
            TakeDamage(damage.damagePoints);
        }
    }
}
