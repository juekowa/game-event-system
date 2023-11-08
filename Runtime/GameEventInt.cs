using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Int", order = 3, fileName = "New Int Game Event")]
    public class GameEventInt : ScriptableObject
    {
        public event Action<int> OnEventRaised = delegate { };
        
        public void RaiseEvent(int value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}