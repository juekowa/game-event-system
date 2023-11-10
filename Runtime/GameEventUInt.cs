using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.Menu + "UInt", order = OrderMode.BaseLevel + 3, fileName = "New UInt Game Event")]
    public class GameEventUint : ScriptableObject
    {
        public event Action<uint> OnEventRaised = delegate { };
        
        public void RaiseEvent(uint value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}