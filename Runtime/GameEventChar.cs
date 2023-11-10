using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.Menu + "Char", order = OrderMode.BaseLevel + 8, fileName = "New Char Game Event")]
    public class GameEventChar : ScriptableObject
    {
        public event Action<char> OnEventRaised = delegate { };
        
        public void RaiseEvent(char value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}