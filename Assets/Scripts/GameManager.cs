using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Transform spawnPoint;
    public Transform energyContainer;
    public GameObject player;

    void Awake()
    {
        Instance = this;
    }

    public void PlayerDied()
    {
        // Respawnear jugador
        player.transform.position = spawnPoint.position;
        player.transform.rotation = spawnPoint.rotation;

        // LAS ESFERAS NO SE DESTRUYEN → aumento de dificultad automática
    }

    public void PlayerWon()
    {
        Debug.Log("WIN!");
        // Podés cargar otra escena si querés:
        // SceneManager.LoadScene("WinScene");
    }
}
