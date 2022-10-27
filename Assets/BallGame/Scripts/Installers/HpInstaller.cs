using BallGame.Scripts.Game.Hp;
using Zenject;

public class HpInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        BindHp();
    }

    private void BindHp()
    {
        Container.Bind<Hp>().FromNew().AsSingle().NonLazy();
    }
}