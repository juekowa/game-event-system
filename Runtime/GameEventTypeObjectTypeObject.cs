using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Type, Object, Type, Object", order = 211, fileName = "New Type, Object, Type, Object Game Event")]
    public class GameEventTypeObjectTypeObject : ScriptableObject
    {
        public event Action<Type, object, Type, object> OnEventRaised = delegate { };
        
        public void RaiseEvent(Type type1, object value1, Type type2, object value2)
        {
            OnEventRaised.Invoke(type1, value1, type2, value2);
        }
    }
}