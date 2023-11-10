using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "BoxCollider2D", order = OrderMode.LevelPhysics + 31, fileName = "New BoxCollider2D Game Event")]
    public class GameEventBoxCollider2D : ScriptableObject
    {
        public event Action<BoxCollider2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(BoxCollider2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}