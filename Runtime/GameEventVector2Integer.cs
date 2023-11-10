using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "Vector2Int", order = OrderMode.LevelUnityTypes + 11, fileName = "New Vector2Int Game Event")]
    public class GameEventVectorInteger : ScriptableObject
    {
        public event Action<Vector2Int> OnEventRaised = delegate { };
        
        public void RaiseEvent(Vector2Int value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}