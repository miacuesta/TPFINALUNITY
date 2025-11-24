using UnityEngine;

public class PlayerDeathHandler : MonoBehaviour
{
    private GameManager gm;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    public void PlayerDied()
    {
        Debug.Log("PLAYER MURIÓ");

        gm.LoadGameOver();
    }
}
