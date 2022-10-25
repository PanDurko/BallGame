using BallGame.Scripts.Game.Score;
using Zenject;

public class ScoreInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Score>().FromNew().AsSingle().NonLazy();
    }
}