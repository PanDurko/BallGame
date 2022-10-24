using System;

namespace BallGame.Scripts.Game.Score
{
    public class Score 
    {
        public event Action<int> ScoreChanged;

        private int _score; 
        
        public void AddScore()
        {
            _score++;

            ScoreChanged?.Invoke(_score);
        }
    }
}
