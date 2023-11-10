using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "Color", order = OrderMode.LevelUnityTypes + 30, fileName = "New Color Game Event")]
    public class GameEventColor : ScriptableObject
    {
        public event Action<Color> OnEventRaised = delegate { };
        
        public void RaiseEvent(Color value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}