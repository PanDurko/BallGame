using UnityEngine;

namespace BallGame.Scripts.Game.Score
{
    public class ScoreTrigger : MonoBehaviour
    {
        [SerializeField] private ScoreInstance score;

        private void OnMouseDown()
        {
            score.Instance.AddScore();
        }
    }
}