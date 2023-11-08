using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Float, Float", order = 22, fileName = "New Float, Float Game Event")]
    public class GameEventFloatFloat : ScriptableObject
    {
        public event Action<float, float> OnEventRaised = delegate { };
        
        public void RaiseEvent(float value1, float value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}