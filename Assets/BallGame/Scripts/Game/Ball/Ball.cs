using System;
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
            _poolObject.ReturnToPool();
        }
    }
}