using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "PolygonCollider2D", order = OrderMode.LevelPhysics + 52, fileName = "New PolygonCollider2D Game Event")]
    public class GameEventPolygonCollider2D : ScriptableObject
    {
        public event Action<PolygonCollider2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(PolygonCollider2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}