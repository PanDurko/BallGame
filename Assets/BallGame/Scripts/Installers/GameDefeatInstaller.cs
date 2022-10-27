using BallGame.Scripts.Game.Hp;
using Zenject;

public class GameDefeatInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        BindGameDefeat();
    }

    private void BindGameDefeat()
    {
        Container.Bind<GameDefeat>().FromNew().AsSingle().NonLazy();
    }
}