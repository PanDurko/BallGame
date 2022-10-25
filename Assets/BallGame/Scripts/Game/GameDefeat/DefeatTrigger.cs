using UnityEngine;
using Zenject; 

namespace BallGame.Scripts.Game.Hp
{
    public class DefeatTrigger : MonoBehaviour
    {
        [Inject] private Hp _hpModel;
        [Inject] private GameDefeat _defeatModel;

        private void OnEnable()
        {
            _hpModel.HpChanged += _defeatModel.CheckHp; 
        }

        private void OnDisable()
        {
            _hpModel.HpChanged -= _defeatModel.CheckHp; 
        }
    }
}