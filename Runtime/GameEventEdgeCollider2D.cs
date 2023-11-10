using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "EdgeCollider2D", order = OrderMode.LevelPhysics + 46, fileName = "New EdgeCollider2D Game Event")]
    public class GameEventEdgeCollider2D : ScriptableObject
    {
        public event Action<EdgeCollider2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(EdgeCollider2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}