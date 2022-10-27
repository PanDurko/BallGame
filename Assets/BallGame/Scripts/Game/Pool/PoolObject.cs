using UnityEngine;

namespace BallGame.Scripts.Game.Pool 
{   
    public class PoolObject : MonoBehaviour
    {
        public void ReturnToPool() 
        {
            gameObject.SetActive(false);
        }
    }
}