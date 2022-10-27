using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace BallGame.Scripts.Game.Hp.UI
{
    public class DefeatScene : MonoBehaviour
    {
        private GameDefeat _defeatModel;

        [Inject]
        private void MonoConstructor(GameDefeat defeatModel)
        {
            _defeatModel = defeatModel; 
        }
        
        private void OnEnable()
        {
            _defeatModel.GameDefeated += OnGameDefeated;
        }

        private void OnDisable()
        {
            _defeatModel.GameDefeated -= OnGameDefeated;
        }

        private void OnGameDefeated()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}