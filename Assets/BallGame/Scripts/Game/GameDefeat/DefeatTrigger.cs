using UnityEngine;
using Zenject; 

namespace BallGame.Scripts.Game.Hp
{
    public class DefeatTrigger : MonoBehaviour
    {
        private Hp _hpModel;
        private GameDefeat _defeatModel;

        [Inject]
        private void MonoConstructor(Hp hpModel, GameDefeat defeatModel)
        {
            _defeatModel = defeatModel; 
            _hpModel = hpModel; 
        }

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