#pragma warning disable 0649
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private UIManager UIManager;
    private static GameManager instance;
    private bool isGamePaused;
    private int score;
    private int bestScore;
    public static GameManager Instance { get => instance; }
    public bool IsGamePaused { get => isGamePaused; }

    public int Score { get => score; set => score = value; }
    public int BestScore { get => bestScore; set => bestScore = value; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        OnGameOpened();
    }
    private void Start()
    {

    }
    public void AddScore()
    {
        score++;
        UIManager.SetScore(score);
        Debug.Log("Your current score: " + score);
    }
    public void End()
    {

        UIManager.SetMedal(score);
        UIManager.SetBestScoreBadge(score > bestScore);
        if (score > bestScore)
        {
            bestScore = score;
        }
        PlayerPrefs.SetInt("BestScore", bestScore);
        UIManager.SetBestScore(bestScore);
        Pause(true);
        Debug.Log("Your best score: " + bestScore);

        UIManager.SetRestartScreen(true);
    }
    public void OnGameOpened()
    {
        score = 0;
        UIManager.SetScore(score);
        UIManager.SetStartScreen(true);
        UIManager.SetRestartScreen(false);
        Pause(true);
    }
    public void Play()
    {
        score = 0;
        UIManager.SetScore(score);
        UIManager.SetStartScreen(false);
        UIManager.SetRestartScreen(false);
        Pause(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
    public void Pause(bool state)
    {
        isGamePaused = state;
        Time.timeScale = state ? 0f : 1f;
    }

}
