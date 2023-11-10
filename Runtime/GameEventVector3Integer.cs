using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "Vector3Int", order = OrderMode.LevelUnityTypes + 21, fileName = "New Vector3Int Game Event")]
    public class GameEventVector3Integer : ScriptableObject
    {
        public event Action<Vector3Int> OnEventRaised = delegate { };
        
        public void RaiseEvent(Vector3Int value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}
