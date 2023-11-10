using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuTwoParameters + "UInt, UInt", order = OrderMode.LevelTwoParameters + 3, fileName = "New UInt, UInt Game Event")]
    public class GameEventUIntUInt : ScriptableObject
    {
        public event Action<uint, uint> OnEventRaised = delegate { };
        
        public void RaiseEvent(uint value1, uint value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}