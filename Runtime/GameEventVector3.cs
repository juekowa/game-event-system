using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "Vector3", order = OrderMode.LevelUnityTypes + 20, fileName = "New Vector3 Game Event")]
    public class GameEventVector3 : ScriptableObject
    {
        public event Action<Vector3> OnEventRaised = delegate { };
        
        public void RaiseEvent(Vector3 value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}