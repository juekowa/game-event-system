using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "Rigidbody2D", order = OrderMode.LevelPhysics + 6, fileName = "New Rigidbody2D Game Event")]
    public class GameEventRigidbody2D : ScriptableObject
    {
        public event Action<Rigidbody2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(Rigidbody2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}