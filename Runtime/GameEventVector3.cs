using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Vector3", order = 5, fileName = "New Vector3 Game Event")]
    public class GameEventVector3 : ScriptableObject
    {
        public event Action<Vector3> OnEventRaised = delegate { };
        
        public void RaiseEvent(Vector3 value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}