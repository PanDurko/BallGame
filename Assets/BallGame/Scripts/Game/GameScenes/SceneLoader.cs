using System; 
using UnityEngine.SceneManagement;

namespace BallGame.Scripts.Game.GameScenes 
{
    public class SceneLoader 
    {
        public void ChangeSceneTo(Scenes newScene) 
        {
            int newSceneId = (int)Enum.Parse(typeof(Scenes), newScene.ToString());
            SceneManager.LoadScene(newSceneId);
        }
    }
}