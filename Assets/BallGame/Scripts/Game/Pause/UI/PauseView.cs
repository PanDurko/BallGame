using TMPro;
using UnityEngine;
using Zenject;

namespace BallGame.Scripts.Game.Pause.UI
{
    public class PauseView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI pauseButtonText; 
    
        private PauseHandler _pauseModel;

        private const string ResumeText = "Resume"; 
        private const string PauseText = "Pause"; 
        
        [Inject]
        private void MonoConstructor(PauseHandler pauseModel)
        {
            _pauseModel = pauseModel; 
        }

        private void OnEnable()
        {
            _pauseModel.GamePaused += OnGamePaused;
        }

        private void OnDisable()
        {
            _pauseModel.GamePaused -= OnGamePaused;
        }

        private void OnGamePaused(bool isPaused)
        {
            pauseButtonText.text = isPaused ? ResumeText : PauseText; 
        } 
    }
}