using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "Sprite", order = OrderMode.LevelUnityTypes + 45, fileName = "New Sprite Game Event")]
    public class GameEventSprite : ScriptableObject
    {
        public event Action<Sprite> OnEventRaised = delegate { };
        
        public void RaiseEvent(Sprite value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}