using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnityTwoParameters + "Vector2Int, Vector2Int", order = OrderMode.LevelUnityTwoParameters + 11, fileName = "New Vector2Int, Vector2Int Game Event")]
    public class GameEventVector2IntegerVector2Integer : ScriptableObject
    {
        public event Action<Vector2Int, Vector2Int> OnEventRaised = delegate { };
        
        public void RaiseEvent(Vector2Int value1, Vector2Int value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}