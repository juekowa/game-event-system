using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "Collision", order = OrderMode.LevelPhysics + 10, fileName = "New Collision Game Event")]
    public class GameEventCollision : ScriptableObject
    {
        public event Action<Collision> OnEventRaised = delegate { };
        
        public void RaiseEvent(Collision value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}