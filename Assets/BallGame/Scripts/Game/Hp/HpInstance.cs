using UnityEngine;

namespace BallGame.Scripts.Game.Hp
{
    public class HpInstance : MonoBehaviour
    {
        public Hp Instance { get; } = new Hp();
    }
}