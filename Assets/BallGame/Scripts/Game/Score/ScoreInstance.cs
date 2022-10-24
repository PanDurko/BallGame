using UnityEngine;

namespace BallGame.Scripts.Game.Score
{
    public class ScoreInstance : MonoBehaviour
    {
        public Score Instance { get; } = new Score();
    }
}