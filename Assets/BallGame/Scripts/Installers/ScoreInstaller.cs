using System.ComponentModel;
using BallGame.Scripts.Game.Score;
using Zenject;

public class ScoreInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        BindScore();
    }

    private void BindScore()
    {
        Container.Bind<Score>().FromNew().AsSingle().NonLazy();
    }
}