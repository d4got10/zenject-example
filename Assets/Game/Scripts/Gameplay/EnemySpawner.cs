using System.Collections;
using UnityEngine;
using Zenject;

namespace Gameplay
{
    public class EnemySpawner : MonoBehaviour
    {
        private Enemy.Factory _factory;
        
        [Inject]
        public void Construct(Enemy.Factory factory)
        {
            _factory = factory;
        }

        public IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);

                var position = GetRandomPosition();
                _factory.Create(position);
            }
        }

        private static Vector3 GetRandomPosition()
        {
            Vector3 position = 10 * Random.insideUnitCircle;
            position.z = position.y;
            position.y = 0;
            return position;
        }
    }
}