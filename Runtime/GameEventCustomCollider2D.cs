using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "CustomCollider2D", order = OrderMode.LevelPhysics + 44, fileName = "New CustomCollider2D Game Event")]
    public class GameEventCustomCollider2D : ScriptableObject
    {
        public event Action<CustomCollider2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(CustomCollider2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}