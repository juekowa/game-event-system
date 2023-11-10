using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuTwoParameters + "Int, Int", order = OrderMode.LevelTwoParameters + 2, fileName = "New Int, Int Game Event")]
    public class GameEventIntInt : ScriptableObject
    {
        public event Action<int, int> OnEventRaised = delegate { };
        
        public void RaiseEvent(int value1, int value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}