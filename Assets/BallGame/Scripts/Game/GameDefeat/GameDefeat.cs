using System;

namespace BallGame.Scripts.Game.Hp
{
    public class GameDefeat
    {
        public event Action GameDefeated;

        public void CheckHp(int hp)
        {
            if(hp <= 0)
                GameDefeated?.Invoke();
        }
    }
}