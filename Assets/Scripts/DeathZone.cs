using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public string gameOverSceneName = "GameOver";

    private void OnTriggerEnter(Collider other)
    {
        // Si cae el jugador → Game Over
        if (other.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(gameOverSceneName);
        }

        // Si cae una energy ball → destruir
        if (other.CompareTag("EnergyBall"))
        {
            Destroy(other.gameObject);
        }
    }
}
