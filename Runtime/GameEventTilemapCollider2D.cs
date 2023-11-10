using System;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuPhysics + "TilemapCollider2D", order = OrderMode.LevelPhysics + 58, fileName = "New TilemapCollider2D Game Event")]
    public class GameEventTilemapCollider2D : ScriptableObject
    {
        public event Action<TilemapCollider2D> OnEventRaised = delegate { };
        
        public void RaiseEvent(TilemapCollider2D value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}