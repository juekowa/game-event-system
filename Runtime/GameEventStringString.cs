using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuTwoParameters + "String, String", order = OrderMode.LevelTwoParameters + 7, fileName = "New String, String Game Event")]
    public class GameEventStringString : ScriptableObject
    {
        public event Action<string, string> OnEventRaised = delegate { };
        
        public void RaiseEvent(string value1, string value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}