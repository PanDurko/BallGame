using UnityEngine;
using UnityEngine.SceneManagement;

namespace BallGame.Scripts.Game.Hp.UI
{
    public class DefeatScene : MonoBehaviour
    {
        [SerializeField] private DefeatInstance defeatModel;

        private void OnEnable()
        {
            defeatModel.Instance.GameDefeated += OnGameDefeated;
        }

        private void OnDisable()
        {
            defeatModel.Instance.GameDefeated -= OnGameDefeated;
        }

        private void OnGameDefeated()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}