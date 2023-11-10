using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "ParticleSystemMainModule", order = OrderMode.LevelUnityTypes + 61, fileName = "New ParticleSystemMainModule Game Event")]
    public class GameEventParticleSystemMainModule : ScriptableObject
    {
        public event Action<ParticleSystem.MainModule> OnEventRaised = delegate { };
        
        public void RaiseEvent(ParticleSystem.MainModule value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}