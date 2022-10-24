using System;
using UnityEngine;

namespace BallGame.Scripts.Game.Hp
{
    public class DefeatTrigger : MonoBehaviour
    {
        [SerializeField] private HpInstance hp;
        [SerializeField] private DefeatInstance defeatModel;

        private void OnEnable()
        {
            hp.Instance.HpChanged += defeatModel.Instance.CheckHp; 
        }

        private void OnDisable()
        {
            hp.Instance.HpChanged -= defeatModel.Instance.CheckHp; 
        }
    }
}