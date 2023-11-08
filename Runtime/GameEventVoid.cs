using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/Void", order = 1, fileName = "New Void Game Event")]
    public class GameEventVoid : ScriptableObject
    {
        public event Action OnEventRaised = delegate { }; //event so it's not nullable; empty delegate so null check is not necessary
    
        public void RaiseEvent()
        {
            OnEventRaised.Invoke();
        }
    }
}