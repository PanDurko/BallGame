using UnityEngine;
using Zenject;

namespace BallGame.Scripts.Game.Score
{
    public class ScoreTrigger : MonoBehaviour
    {
        [Inject] private Score _scoreModel;

        private void OnMouseDown()
        {
            _scoreModel.AddScore();
        }
    }
}