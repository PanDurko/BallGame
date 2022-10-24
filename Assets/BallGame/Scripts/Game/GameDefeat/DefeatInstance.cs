using UnityEngine;

namespace BallGame.Scripts.Game.Hp
{
    public class DefeatInstance : MonoBehaviour
    {
        public GameDefeat Instance { get; } = new GameDefeat();
    }
}