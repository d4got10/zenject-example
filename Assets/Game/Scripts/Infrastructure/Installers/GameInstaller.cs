using Gameplay;
using Zenject;

namespace Infrastructure.Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallPersistentService();
            //Install something else...
        }

        private void InstallPersistentService()
        {
            Container
                .Bind<IPersistentService>()
                .To<PersistentService>()
                .AsSingle()
                .NonLazy();
        }
    }
}
