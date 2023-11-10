using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "Material", order = OrderMode.LevelUnityTypes + 35, fileName = "New Material Game Event")]
    public class GameEventMaterial : ScriptableObject
    {
        public event Action<Material> OnEventRaised = delegate { };
        
        public void RaiseEvent(Material value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}