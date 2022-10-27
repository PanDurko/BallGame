using System;
using BallGame.Scripts.Game.Hp;
using BallGame.Scripts.Game.Pool;
using BallGame.Scripts.Game.Score;
using UnityEngine;

namespace BallGame.Scripts.Game
{
    [RequireComponent(typeof(BallMover), typeof(BallColor))]
    [RequireComponent(typeof(ScoreTrigger), typeof(PoolObject))]
    public class Ball : MonoBehaviour
    {
        private PoolObject _poolObject;

        private void Awake()
        {
            _poolObject = GetComponent<PoolObject>();
        }

        private void OnMouseDown()
        {
            if(Time.timeScale == 0)
                return;
            
            _poolObject.ReturnToPool();
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if(collider.TryGetComponent(out HpTrigger hpTrigger))
                _poolObject.ReturnToPool();
        }
    }
}