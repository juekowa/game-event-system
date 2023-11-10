using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "SphereCollider", order = OrderMode.LevelPhysics + 54, fileName = "New SphereCollider Game Event")]
    public class GameEventSphereCollider : ScriptableObject
    {
        public event Action<SphereCollider> OnEventRaised = delegate { };
        
        public void RaiseEvent(SphereCollider value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}