using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuList + "GameObject", order = OrderMode.LevelList + 20, fileName = "New List(GameObject) - Game Event")]
    public class GameEventListGameObject : ScriptableObject
    {
        public event Action<List<GameObject>> OnEventRaised = delegate { };
        
        public void RaiseEvent(List<GameObject> value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}