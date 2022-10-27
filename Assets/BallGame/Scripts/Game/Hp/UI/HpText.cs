using TMPro;
using UnityEngine;
using Zenject;

namespace BallGame.Scripts.Game.Hp.UI
{
    public class HpText : MonoBehaviour
    {      
        private TextMeshProUGUI _hpText; 
     
        private Hp _hpModel;
        
        [Inject]
        private void MonoConstructor(Hp hpModel) 
        {
            _hpModel = hpModel; 
        }
        
        private void Awake()
        {
            _hpText = GetComponent<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            _hpModel.HpChanged += OnHpChanged;
        }

        private void OnDisable()
        {
            _hpModel.HpChanged -= OnHpChanged;
        }

        private void OnHpChanged(int currentHp)
        {
            _hpText.text = currentHp.ToString();
        }
    }
}