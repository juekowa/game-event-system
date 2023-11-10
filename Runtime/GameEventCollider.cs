using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "Collider", order = OrderMode.LevelPhysics + 20, fileName = "New Collider Game Event")]
    public class GameEventCollider : ScriptableObject
    {
        public event Action<Collider> OnEventRaised = delegate { };
        
        public void RaiseEvent(Collider value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}