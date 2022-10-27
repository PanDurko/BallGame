using TMPro;
using UnityEngine;
using Zenject; 

namespace BallGame.Scripts.Game.Score.UI
{
    public class ScoreText : MonoBehaviour
    {
        private TextMeshProUGUI _scoreText;
    
        private Score _scoreModel;
    
        [Inject]
        private void MonoConstructor(Score scoreModel) 
        {
            _scoreModel = scoreModel; 
        }

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