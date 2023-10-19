using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private gameManager GameManger;
    [SerializeField] private TextMeshProUGUI finalScoreText;
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private GameObject fuck;
    public void SetText(int score)
    {
        scoreText.text = score.ToString();
    }


    private void Awake()
    {
        GameManger= FindObjectOfType<gameManager>();
    }

    public void Replay()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("CandyCatch");
    }
    public void setFinalText(int score)
    {
        finalScoreText.text = "You Scored: " + score;
        if (score < 15)
        {
            gameOverText.text = "Sadness";
            return;
        }
        else if (score < 35)
        {
            gameOverText.text = "Suger Rush";
            return;
        }
        else if (score < 50)
        {
            gameOverText.text = "Halloween";
            return;
        }
        else
        {
            gameOverText.text = "Candy Craze";
        }
        
    }

    public void char1()
    {
        gameManager.character = 0;
        GameManger.setActive(0);
        fuck.SetActive(false);
    }
    public void char2()
    {
        gameManager.character = 1;
        GameManger.setActive(1);
        fuck.SetActive(false);
    }
}
