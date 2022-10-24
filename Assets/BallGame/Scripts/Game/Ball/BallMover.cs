using UnityEngine;

namespace BallGame.Scripts.Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallMover : MonoBehaviour
    {
        [SerializeField] private float speed; 
        
        private void Update() 
        {
            Move(); 
        }
        
        public void Move() 
        {
            transform.position += Vector3.down * (speed * Time.deltaTime);
        }
    }
}