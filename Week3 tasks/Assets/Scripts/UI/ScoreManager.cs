using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    void Update()
    {
        scoreText.text = "Score :" + score.ToString();
    }


    public void AddScore(int amount)
    {
        score += amount;

        if(score > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "HighScore: " + score.ToString();
        }  
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteAll();
    }
}
