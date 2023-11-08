using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Object", order = 102, fileName = "New Object Game Event")]
    public class GameEventObject : ScriptableObject
    {
        public event Action<object> OnEventRaised = delegate { };
        
        public void RaiseEvent(object value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}