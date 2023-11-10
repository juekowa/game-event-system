using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "Texture", order = OrderMode.LevelUnityTypes + 40, fileName = "New Texture Game Event")]
    public class GameEventTexture : ScriptableObject
    {
        public event Action<Texture> OnEventRaised = delegate { };
        
        public void RaiseEvent(Texture value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}