using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.Menu + "Type, Object, Object", order = OrderMode.LevelComplex + 15, fileName = "New Type, Object, Object Game Event")]
    public class GameEventTypeObjectObject : ScriptableObject
    {
        public event Action<Type, object, object> OnEventRaised = delegate { };
        
        public void RaiseEvent(Type type, object value1, object value2)
        {
            OnEventRaised.Invoke(type, value1, value2);
        }
    }
}