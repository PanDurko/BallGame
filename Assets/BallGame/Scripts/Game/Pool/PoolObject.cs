using UnityEngine;

namespace BallGame.Scripts.Game.Pool 
{   
    public class PoolObject : MonoBehaviour
    {
        public void ReturnToPool() 
        {
            gameObject.SetActive(false);
        }   
        
        public void ReturnToPool(float destroyTime)
        {
            destroyTime -= Time.deltaTime;
            
            if(destroyTime <= 0)
                gameObject.SetActive(false);
        }   
    }
}