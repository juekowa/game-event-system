using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnityTwoParameters + "Vector3, Vector3", order = OrderMode.LevelUnityTwoParameters + 20, fileName = "New Vector3, Vector3 Game Event")]
    public class GameEventVector3Vector3 : ScriptableObject
    {
        public event Action<Vector3, Vector3> OnEventRaised = delegate { };
        
        public void RaiseEvent(Vector3 value1, Vector3 value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}