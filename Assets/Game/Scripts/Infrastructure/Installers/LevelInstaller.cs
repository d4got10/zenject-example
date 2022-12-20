using Gameplay;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers
{
    public class LevelInstaller : MonoInstaller
    {
        [SerializeField] private Transform _playerSpawnPoint;
        
        [SerializeField] private Player _playerPrefab;
        [SerializeField] private Enemy _enemyPrefab;
        
        public override void InstallBindings()
        {
            InstallServiceA();
            
            InstallPlayer();
            InstallEnemyFactory();
        }
        
        private void InstallServiceA()
        {
            Container
                .Bind<IServiceA>()
                .To<ServiceA>()
                .AsSingle();
        }

        private void InstallPlayer()
        {
            var player = Container.InstantiatePrefabForComponent<Player>(_playerPrefab, 
                _playerSpawnPoint.position, 
                _playerSpawnPoint.rotation, 
                _playerSpawnPoint);
            
            Container
                .Bind<Player>()
                .ToSelf()
                .FromInstance(player);
        }

        private void InstallEnemyFactory()
        {
            Container
                .Bind<Enemy.Factory>()
                .To<EnemyFactory>()
                .AsSingle()
                .WithArguments(_enemyPrefab);
        }
    }
}
