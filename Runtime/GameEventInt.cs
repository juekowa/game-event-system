using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.Menu + "Int", order = OrderMode.BaseLevel + 2, fileName = "New Int Game Event")]
    public class GameEventInt : ScriptableObject
    {
        public event Action<int> OnEventRaised = delegate { };
        
        public void RaiseEvent(int value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}