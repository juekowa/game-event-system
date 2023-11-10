using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "MeshFilter", order = OrderMode.LevelUnityTypes + 52, fileName = "New MeshFilter Game Event")]
    public class GameEventMeshFilter : ScriptableObject
    {
        public event Action<MeshFilter> OnEventRaised = delegate { };
        
        public void RaiseEvent(MeshFilter value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}