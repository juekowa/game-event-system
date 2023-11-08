using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Color", order = 5, fileName = "New Color Game Event")]
    public class GameEventColor : ScriptableObject
    {
        public event Action<Color> OnEventRaised = delegate { };
        
        public void RaiseEvent(Color value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}