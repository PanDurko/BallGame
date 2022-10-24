using System.Collections;
using UnityEngine; 

namespace BallGame.Scripts.Game.Spawner
{
    public class BallSpawner : MonoBehaviour
    {
        [SerializeField] private Pool.Pool pool;
        [SerializeField] private Pool.PoolObject poolObject;

        [SerializeField] private float xPosition;
        [SerializeField] private float ballDestroyTime;
        [SerializeField] private float nextBallTime;

        private void Start()
        {
            StartCoroutine(SpawnBalls());
        }

        private IEnumerator SpawnBalls()
        {
            while (true)
            {
                yield return new WaitForSeconds(nextBallTime);
            
                Vector3 newPosition = GetPosition();
                pool.GetFreeElement(newPosition); 
                
                poolObject.ReturnToPool(ballDestroyTime);
            }
        }

        private Vector3 GetPosition()
        {
            float xRandomPosition = Random.Range(-xPosition, xPosition);
            return new Vector3(xRandomPosition, transform.position.y, transform.position.z);
        }
    }    
}
