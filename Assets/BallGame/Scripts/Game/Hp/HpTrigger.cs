using System;
using UnityEngine;

namespace BallGame.Scripts.Game.Hp
{
    public class HpTrigger : MonoBehaviour
    {
        [SerializeField] private HpInstance hp;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.TryGetComponent(out Ball ball))
            {
                hp.Instance.DecreaseHp();
            }
        }
    }
}