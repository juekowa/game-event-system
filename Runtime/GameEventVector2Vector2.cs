using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnityTwoParameters + "Vector2, Vector2", order = OrderMode.LevelUnityTwoParameters + 10, fileName = "New Vector2, Vector2 Game Event")]
    public class GameEventVector2Vector2 : ScriptableObject
    {
        public event Action<Vector2, Vector2> OnEventRaised = delegate { };
        
        public void RaiseEvent(Vector2 value1, Vector2 value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}