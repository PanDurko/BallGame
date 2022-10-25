using BallGame.Scripts.Game.Hp;
using Zenject;

public class HpInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Hp>().FromNew().AsSingle().NonLazy();
    }
}