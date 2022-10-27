using BallGame.Scripts.Game.GameScenes;
using Zenject;

namespace BallGame.Scripts.Installers
{
    public class SceneLoaderInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindSceneLoader();
        }

        private void BindSceneLoader()
        {
            Container.Bind<SceneLoader>().FromNew().AsSingle().NonLazy();
        }
    }
}