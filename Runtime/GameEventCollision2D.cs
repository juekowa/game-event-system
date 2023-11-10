using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "Collision2D", order = OrderMode.LevelPhysics + 11, fileName = "New Collision2D Game Event")]
    public class GameEventCollision2D : ScriptableObject
    {
        public event Action<Collision2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(Collision2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}