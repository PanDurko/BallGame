using BallGame.Scripts.Game.GameScenes;
using UnityEngine;
using Zenject;

namespace BallGame.Scripts.Game.Hp.UI
{
    public class DefeatView : MonoBehaviour
    {
        private SceneLoader _sceneLoader; 
        private GameDefeat _defeatModel;

        [Inject]
        private void MonoConstructor(GameDefeat defeatModel, SceneLoader sceneLoader)
        {
            _defeatModel = defeatModel;
            _sceneLoader = sceneLoader; 
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
            _sceneLoader.ChangeSceneTo(Scenes.DefeatScene);
        }
    }
}