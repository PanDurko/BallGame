using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace BallGame.Scripts.Game.Hp.UI
{
    public class DefeatScene : MonoBehaviour
    {
        [Inject] private GameDefeat _defeatModel;

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