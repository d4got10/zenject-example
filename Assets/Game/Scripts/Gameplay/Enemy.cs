using UnityEngine;
using Zenject;

namespace Gameplay
{
    public class Enemy : MonoBehaviour
    {
        private Player _player;
        
        [Inject]
        public void Construct(Player player)
        {
            _player = player;
        }

        public void Update()
        {
            transform.position += (_player.transform.position - transform.position).normalized * Time.deltaTime;
        }

        public abstract class Factory
        {
            public abstract Enemy Create(Vector3 position);
        }
    }

    public class EnemyFactory : Enemy.Factory
    {
        public EnemyFactory(Enemy prefab, IInstantiator instantiator)
        {
            _prefab = prefab;
            _instantiator = instantiator;
        }

        private readonly Enemy _prefab;
        private readonly IInstantiator _instantiator;

        public override Enemy Create(Vector3 position) => 
            _instantiator.InstantiatePrefabForComponent<Enemy>(_prefab, position, Quaternion.identity, null);
    }
}