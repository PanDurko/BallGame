using System;
using UnityEngine;
using Zenject;

namespace BallGame.Scripts.Game.Hp
{
    public class HpTrigger : MonoBehaviour
    {
        private Hp _hpModel;
    
        [Inject]
        private void MonoConstructor(Hp hpModel) 
        {
            _hpModel = hpModel; 
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.TryGetComponent(out Ball ball))
            {
                _hpModel.DecreaseHp();
            }
        }
    }
}