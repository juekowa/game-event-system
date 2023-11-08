using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Type, Object", order = 201, fileName = "New Type, Object Game Event")]
    public class GameEventTypeObject : ScriptableObject
    {
        public event Action<Type, object> OnEventRaised = delegate { };
        
        public void RaiseEvent(Type type, object value)
        {
            OnEventRaised.Invoke(type, value);
        }
    }
}