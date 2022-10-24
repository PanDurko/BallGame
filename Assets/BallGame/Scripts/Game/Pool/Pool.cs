using System;
using System.Collections.Generic;
using UnityEngine;

namespace BallGame.Scripts.Game.Pool 
{  
    public class Pool : MonoBehaviour
    {
        [SerializeField] private PoolObject prefab;
        [SerializeField] private Transform container;

        [SerializeField] private int minCapacity;
        [SerializeField] private int maxCapacity;

        [SerializeField] private bool autoExpand;

        private List<PoolObject> _pool; 

        private void OnValidate()
        {
            if(autoExpand)
                maxCapacity = Int32.MaxValue;
        }

        private void Start()
        {
            CreatePool();
        }

        private void CreatePool()
        {
            _pool = new List<PoolObject>(minCapacity);

            for (int i = 0; i < minCapacity; i++)
                CreateElement(); 
        }

        private PoolObject CreateElement(bool isActiveByDefault = false)
        {
            var newObject = Instantiate(prefab, container);
            newObject.gameObject.SetActive(isActiveByDefault);
            
            _pool.Add(newObject);

            return newObject; 
        }

        public bool TryGetElement(out PoolObject element)
        {
            foreach (var item in _pool)
            {
                if (!item.gameObject.activeInHierarchy)
                {
                    element = item; 
                    item.gameObject.SetActive(true);
                    return true;
                }
            }

            element = null;
            return false; 
        }

        public PoolObject GetFreeElement()
        {
            if (TryGetElement(out var element))
                return element;

            if (autoExpand)
                return CreateElement(true);
            
            if(_pool.Count < maxCapacity)
                return CreateElement(true);

            throw new Exception("Pool is over!");
        }
        
        public PoolObject GetFreeElement(Vector3 position)
        {
            var element = GetFreeElement();
            element.transform.position = position;
            return element; 
        }
    }
}
