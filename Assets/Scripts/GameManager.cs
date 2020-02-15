#pragma warning disable 0649
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private int score;
    private int bestScore;
    public static GameManager Instance { get => instance; }
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
    }
    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore",0);
    }
    public void AddScore()
    {
        score++;
        Debug.Log("Your current score: " + score);
    }
    public void StopGame()
    {
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("BestScore", bestScore);
        }
        Debug.Log("Your best score: "+ bestScore);
        Time.timeScale = 0f;
    }
    public void ResetGame()
    {
        score = 0;
        Time.timeScale = 1f;
    }

}
