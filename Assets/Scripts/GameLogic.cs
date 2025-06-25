using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public int playerScore;
    public Text playerScoreText;
    public GameObject gameOverScreen;
    public bool gameIsActive = true;

    [ContextMenu("Increase Score")]
    public void IncrementPlayerScore()
    {
        if (gameIsActive)
        { 
            playerScore++;
            playerScoreText.text = playerScore.ToString();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        gameIsActive = false;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainGameplayScene");        
    } 
}
