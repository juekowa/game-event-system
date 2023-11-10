using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.Menu + "Double", order = OrderMode.BaseLevel + 6, fileName = "New Double Game Event")]
    public class GameEventDouble : ScriptableObject
    {
        public event Action<double> OnEventRaised = delegate { };
        
        public void RaiseEvent(double value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}