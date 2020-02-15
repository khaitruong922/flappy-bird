#pragma warning disable 0649
using UnityEngine;

public class ScoreAdder : MonoBehaviour, IScoreAdder
{
    public void AddScore()
    {
        GameManager.Instance.AddScore();
    }
}
