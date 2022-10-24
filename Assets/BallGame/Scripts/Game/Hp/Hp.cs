using System;

namespace BallGame.Scripts.Game.Hp
{
    public class Hp
    {
        public event Action<int> HpChanged;

            private int _currentHp = 100;

        public void DecreaseHp()
        {
            _currentHp -= 5;

            HpChanged?.Invoke(_currentHp); 
        }
    }   
}