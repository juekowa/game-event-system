using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Vector3", order = 4, fileName = "New Vector2 Game Event")]
    public class GameEventVector : ScriptableObject
    {
        public event Action<Vector2> OnEventRaised = delegate { };
        
        public void RaiseEvent(Vector2 value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}