using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "Rigidbody", order = OrderMode.LevelPhysics + 5, fileName = "New Rigidbody Game Event")]
    public class GameEventRigidbody : ScriptableObject
    {
        public event Action<Rigidbody> OnEventRaised = delegate { };
        
        public void RaiseEvent(Rigidbody value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}