using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Color, Color", order = 25, fileName = "New Color, Color Game Event")]
    public class GameEventColorColor : ScriptableObject
    {
        public event Action<Color, Color> OnEventRaised = delegate { };
        
        public void RaiseEvent(Color value1, Color value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}