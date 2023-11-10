using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "Collider2D", order = OrderMode.LevelPhysics + 21, fileName = "New Collider2D Game Event")]
    public class GameEventCollider2D : ScriptableObject
    {
        public event Action<Collider2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(Collider2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}