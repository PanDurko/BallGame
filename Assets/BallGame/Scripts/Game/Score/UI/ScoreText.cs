using System;
using TMPro;
using UnityEngine;

namespace BallGame.Scripts.Game.Score.UI
{
    public class ScoreText : MonoBehaviour
    {
        [SerializeField] private ScoreInstance scoreInstance;

        private TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            scoreInstance.Instance.ScoreChanged += OnScoreChanged;
        }

        private void OnDisable()
        {
            scoreInstance.Instance.ScoreChanged -= OnScoreChanged;
        }

        private void OnScoreChanged(int score)
        {
            _scoreText.text = score.ToString();
        } 
    }
}