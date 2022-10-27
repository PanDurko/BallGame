using UnityEngine; 
using Zenject;

namespace BallGame.Scripts.Game.Pause
{
    public class PauseTrigger : MonoBehaviour
    {
        private PauseHandler _pauseModel;

        [Inject]
        private void MonoConstructors(PauseHandler pauseModel)
        {
            _pauseModel = pauseModel; 
        }

        public void OnPauseButtonClicked()
        {
            _pauseModel.TryPauseGame();
        }
    }
}