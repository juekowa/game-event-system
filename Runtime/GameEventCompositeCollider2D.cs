using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "CompositeCollider2D", order = OrderMode.LevelPhysics + 42, fileName = "New CompositeCollider2D Game Event")]
    public class GameEventCompositeCollider2D: ScriptableObject
    {
        public event Action<CompositeCollider2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(CompositeCollider2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}