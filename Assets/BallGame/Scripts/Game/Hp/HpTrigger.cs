using System;
using UnityEngine;
using Zenject;

namespace BallGame.Scripts.Game.Hp
{
    public class HpTrigger : MonoBehaviour
    {
        [Inject] private Hp _hpModel;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.TryGetComponent(out Ball ball))
            {
                _hpModel.DecreaseHp();
            }
        }
    }
}