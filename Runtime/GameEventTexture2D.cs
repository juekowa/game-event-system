using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "Texture2D", order = OrderMode.LevelUnityTypes + 41, fileName = "New Texture2D Game Event")]
    public class GameEventTexture2D : ScriptableObject
    {
        public event Action<Texture2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(Texture2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}