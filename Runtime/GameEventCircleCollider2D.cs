using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "CircleCollider2D", order = OrderMode.LevelPhysics + 40, fileName = "New CircleCollider2D Game Event")]
    public class GameEventCircleCollider2D : ScriptableObject
    {
        public event Action<CircleCollider2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(CircleCollider2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}