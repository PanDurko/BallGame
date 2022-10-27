using UnityEngine;
using Zenject; 

namespace BallGame.Scripts.Game.Score 
{
    public class BestScore : MonoBehaviour
    {
        private Score _scoreModel; 
        
        private const string ScoreKey = "Score";
        
        [Inject]
        private void MonoInstaller(Score scoreModel) 
        {
            _scoreModel = scoreModel; 
        }   
        
        private void OnEnable() 
        {
            _scoreModel.ScoreChanged += SaveCurrentScore; 
        }
        
        private void OnDisable() 
        {
            _scoreModel.ScoreChanged -= SaveCurrentScore;
        }

        private void SaveCurrentScore(int currentScore)
        {
            PlayerPrefs.SetInt(ScoreKey, currentScore);
        }
    }
}
