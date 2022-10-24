using UnityEngine;
using Random = UnityEngine.Random;

namespace BallGame.Scripts.Game
{
    [RequireComponent(typeof(Renderer))]
    public class BallColor : MonoBehaviour
    {
        private Renderer _ballRenderer;

        private void Awake()
        {
            _ballRenderer = GetComponent<Renderer>();
            SetNewRandomColor();
        }

        private void SetNewRandomColor()
        {
            Color newColor = Random.ColorHSV();
            _ballRenderer.material.color = newColor; 
        }
    }
}