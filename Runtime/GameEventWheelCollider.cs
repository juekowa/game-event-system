using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "WheelCollider", order = OrderMode.LevelPhysics + 60, fileName = "New WheelCollider Game Event")]
    public class GameEventWheelCollider : ScriptableObject
    {
        public event Action<WheelCollider> OnEventRaised = delegate { };
        
        public void RaiseEvent(WheelCollider value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}