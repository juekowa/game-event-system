using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuList + "Object", order = OrderMode.LevelList + 10, fileName = "New List(Object) - Game Event")]
    public class GameEventListObject : ScriptableObject
    {
        public event Action<List<object>> OnEventRaised = delegate { };
        
        public void RaiseEvent(List<object> value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}