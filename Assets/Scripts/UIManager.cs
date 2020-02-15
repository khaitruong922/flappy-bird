#pragma warning disable 0649
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[System.Serializable]
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject startScreen;
    [SerializeField]
    private GameObject restartScreen;
    [SerializeField]
    private GameObject newBestScoreBadge;
    [SerializeField]
    private Image medal;
    [SerializeField]
    private TextMeshProUGUI ingameScore, score, bestScore;
    [SerializeField]
    private Sprite blank,bronze, silver, gold, platinum;
    public void SetScore(int score)
    {
        this.ingameScore.text = score.ToString();
        this.score.text = score.ToString();
    }
    public void SetBestScoreBadge(bool state)
    {
        newBestScoreBadge.SetActive(state);
    }
    public void SetBestScore(int score)
    {
        this.bestScore.text = score.ToString();
    }
    public void SetStartScreen(bool state)
    {
        startScreen.SetActive(state);
    }
    public void SetRestartScreen(bool state)
    {
        restartScreen.SetActive(state);
    }
    public void SetMedal(int score)
    {
        if (score < 10)
        {
            medal.sprite = blank;
        }
        else if (score < 20)
        {
            medal.sprite = bronze;
        }
        else if (score < 30)
        {
            medal.sprite = silver;
        }
        else if (score < 40)
        {
            medal.sprite = gold;
        }
        else
        {
            medal.sprite = platinum;
        }
    }
}
