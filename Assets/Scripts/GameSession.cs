using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    public static GameSession Instance;

    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int lives = 3;
    [SerializeField] int score = 0;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        livesText.text = lives.ToString();
        scoreText.text = score.ToString();
    }

    void Update()
    {
        
    }

    public void ProcessPlayerDeath()
    {
        if(lives > 1)
        {
            lives--;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            livesText.text = lives.ToString();
        }
        else
        {
            ResetGameSession();
        }
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }

    private void ResetGameSession()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }
}
