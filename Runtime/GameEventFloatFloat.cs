using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuTwoParameters + "Float, Float", order = OrderMode.LevelTwoParameters + 5, fileName = "New Float, Float Game Event")]
    public class GameEventFloatFloat : ScriptableObject
    {
        public event Action<float, float> OnEventRaised = delegate { };
        
        public void RaiseEvent(float value1, float value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}