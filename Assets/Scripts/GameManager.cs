using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void LoadWinScreen()
    {
        SceneManager.LoadScene("WinScreen");
    }
}
