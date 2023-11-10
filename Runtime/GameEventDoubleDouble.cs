using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuTwoParameters + "Double, Double", order = OrderMode.LevelTwoParameters + 6, fileName = "New Double, Double Game Event")]
    public class GameEventDoubleDouble : ScriptableObject
    {
        public event Action<double, double> OnEventRaised = delegate { };
        
        public void RaiseEvent(double value1, double value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}