using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuTwoParameters + "Char, Char", order = OrderMode.LevelTwoParameters + 8, fileName = "New Char, Char Game Event")]
    public class GameEventCharChar : ScriptableObject
    {
        public event Action<char, char> OnEventRaised = delegate { };
        
        public void RaiseEvent(char value1, char value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}