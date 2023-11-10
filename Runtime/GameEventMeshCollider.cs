using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "MeshCollider", order = OrderMode.LevelPhysics + 50, fileName = "New MeshCollider Game Event")]
    public class GameEventMeshCollider : ScriptableObject
    {
        public event Action<MeshCollider> OnEventRaised = delegate { };
        
        public void RaiseEvent(MeshCollider value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}