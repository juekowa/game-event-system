using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnityTwoParameters + "Vector3Int, Vector3Int", order = OrderMode.LevelUnityTwoParameters + 21, fileName = "New Vector3Int, Vector3Int Game Event")]
    public class GameEventVector3IntegerVector3Integer : ScriptableObject
    {
        public event Action<Vector3Int, Vector3Int> OnEventRaised = delegate { };
        
        public void RaiseEvent(Vector3Int value1, Vector3Int value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}