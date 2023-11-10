using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "ParticleSystem", order = OrderMode.LevelUnityTypes + 60, fileName = "New ParticleSystem Game Event")]
    public class GameEventParticleSystem : ScriptableObject
    {
        public event Action<ParticleSystem> OnEventRaised = delegate { };
        
        public void RaiseEvent(ParticleSystem value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}