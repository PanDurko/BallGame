using System;
using UnityEngine;

namespace BallGame.Scripts.Game.Pause
{
    public class PauseHandler
    {
        public event Action<bool> GamePaused;

        private bool _isPaused = false;

        public void TryPauseGame()
        {
            _isPaused ^= true;

            Time.timeScale = _isPaused ? 0 : 1; 
            GamePaused?.Invoke(_isPaused);
        }
    }
}