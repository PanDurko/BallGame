using BallGame.Scripts.Game.Pause;
using Zenject;

namespace BallGame.Scripts.Installers
{
    public class PauseInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindPause();
        }

        private void BindPause()
        {
            Container.Bind<PauseHandler>().FromNew().AsSingle().NonLazy();
        }
    }
}