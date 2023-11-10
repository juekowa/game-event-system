using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "TerrainCollider", order = OrderMode.LevelPhysics + 56, fileName = "New TerrainCollider Game Event")]
    public class GameEventTerrainCollider : ScriptableObject
    {
        public event Action<TerrainCollider> OnEventRaised = delegate { };
        
        public void RaiseEvent(TerrainCollider value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}