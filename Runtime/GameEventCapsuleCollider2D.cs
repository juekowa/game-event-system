using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "CapsuleCollider2D", order = OrderMode.LevelPhysics + 36, fileName = "New CapsuleCollider2D Game Event")]
    public class GameEventCapsuleCollider2D : ScriptableObject
    {
        public event Action<CapsuleCollider2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(CapsuleCollider2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}