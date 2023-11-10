using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "MeshRenderer", order = OrderMode.LevelUnityTypes + 51, fileName = "New MeshRenderer Game Event")]
    public class GameEventMeshRenderer : ScriptableObject
    {
        public event Action<MeshRenderer> OnEventRaised = delegate { };
        
        public void RaiseEvent(MeshRenderer value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}