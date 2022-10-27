using UnityEngine;
using Zenject;

namespace BallGame.Scripts.Game.Score
{
    public class ScoreTrigger : MonoBehaviour
     {
         private Score _scoreModel;
 
         [Inject]
         private void MonoConstructor(Score scoreModel) 
         {
             _scoreModel = scoreModel; 
         }
 
         private void OnMouseDown()
         {
             if(Time.timeScale == 0)
                return;
             
             _scoreModel.AddScore();
         }
     }
 }