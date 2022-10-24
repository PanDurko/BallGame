using System;
using TMPro;
using UnityEngine;

namespace BallGame.Scripts.Game.Hp.UI
{
    public class HpText : MonoBehaviour
    {
        [SerializeField] private HpInstance hp; 
            
        private TextMeshProUGUI _hpText; 
        
        private void Awake()
        {
            _hpText = GetComponent<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            hp.Instance.HpChanged += OnHpChanged;
        }

        private void OnDisable()
        {
            hp.Instance.HpChanged -= OnHpChanged;
        }

        private void OnHpChanged(int currentHp)
        {
            _hpText.text = currentHp.ToString();
        }
    }
}