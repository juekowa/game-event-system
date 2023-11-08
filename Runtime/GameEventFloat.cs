using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Float", order = 2, fileName = "New Float Game Event")]
    public class GameEventFloat : ScriptableObject
    {
        public event Action<float> OnEventRaised = delegate { };
        
        public void RaiseEvent(float value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}