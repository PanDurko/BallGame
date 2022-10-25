using TMPro;
using UnityEngine;
using Zenject; 

namespace BallGame.Scripts.Game.Score.UI
{
    public class ScoreText : MonoBehaviour
    {
        [Inject] private Score _scoreModel;

        private TextMeshProUGUI _scoreText;

        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            _scoreModel.ScoreChanged += OnScoreChanged;
        }

        private void OnDisable()
        {
            _scoreModel.ScoreChanged -= OnScoreChanged;
        }

        private void OnScoreChanged(int score)
        {
            _scoreText.text = score.ToString();
        } 
    }
}