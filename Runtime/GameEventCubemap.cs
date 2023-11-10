using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "Cubemap", order = OrderMode.LevelUnityTypes + 44, fileName = "New Cubemap Game Event")]
    public class GameEventCubemap : ScriptableObject
    {
        public event Action<Cubemap> OnEventRaised = delegate { };
        
        public void RaiseEvent(Cubemap value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}