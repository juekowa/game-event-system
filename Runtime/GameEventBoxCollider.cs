using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "BoxCollider", order = OrderMode.LevelPhysics + 30, fileName = "New BoxCollider Game Event")]
    public class GameEventBoxCollider : ScriptableObject
    {
        public event Action<BoxCollider> OnEventRaised = delegate { };
        
        public void RaiseEvent(BoxCollider value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}