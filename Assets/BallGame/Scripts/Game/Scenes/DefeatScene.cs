using TMPro;
using UnityEngine;
using Zenject;

namespace BallGame.Scripts.Game.GameScenes
{
    public class DefeatScene : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI totalScoreText;
        
        private SceneLoader _sceneLoader; 
        
        private const string ScoreKey = "Score";

        [Inject]
        private void MonoConstructor(SceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader; 
        }

        private void Awake()
        {
            SetBestScore();
        }

        private void SetBestScore()
        {
            int totalScore = PlayerPrefs.GetInt(ScoreKey);
            totalScoreText.text = totalScore.ToString();
        }

        public void RestartGame()
        {
            _sceneLoader.ChangeSceneTo(Scenes.PlayScene);
        }
    }
}