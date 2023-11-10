using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "CapsuleCollider", order = OrderMode.LevelPhysics + 35, fileName = "New CapsuleCollider Game Event")]
    public class GameEventCapsuleCollider : ScriptableObject
    {
        public event Action<CapsuleCollider> OnEventRaised = delegate { };
        
        public void RaiseEvent(CapsuleCollider value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}