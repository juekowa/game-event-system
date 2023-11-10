using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.Menu + "Bool", order = OrderMode.BaseLevel + 4, fileName = "New Bool Game Event")]
    public class GameEventBool : ScriptableObject
    {
        public event Action<bool> OnEventRaised = delegate { };
        
        public void RaiseEvent(bool value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}