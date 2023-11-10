using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "Mesh", order = OrderMode.LevelUnityTypes + 50, fileName = "New Mesh Game Event")]
    public class GameEventMesh : ScriptableObject
    {
        public event Action<Mesh> OnEventRaised = delegate { };
        
        public void RaiseEvent(Mesh value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}