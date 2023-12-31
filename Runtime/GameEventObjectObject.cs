using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuTwoParameters + "Object, Object", order = OrderMode.LevelTwoParameters + 9, fileName = "New Object, Object Game Event")]
    public class GameEventObjectObject : ScriptableObject
    {
        public event Action<object, object> OnEventRaised = delegate { };
        
        public void RaiseEvent(object value1, object value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}