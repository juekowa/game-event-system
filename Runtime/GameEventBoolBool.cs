using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuTwoParameters + "Bool, Bool", order = OrderMode.LevelTwoParameters + 4, fileName = "New Bool, Bool Game Event")]
    public class GameEventBoolBool : ScriptableObject
    {
        public event Action<bool, bool> OnEventRaised = delegate { };
        
        public void RaiseEvent(bool value1, bool value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}