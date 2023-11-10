using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.Menu + "String", order = OrderMode.BaseLevel + 7, fileName = "New String Game Event")]
    public class GameEventString : ScriptableObject
    {
        public event Action<string> OnEventRaised = delegate { };
        
        public void RaiseEvent(string value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}