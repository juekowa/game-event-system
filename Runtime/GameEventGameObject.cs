using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnity + "GameObject", order = OrderMode.LevelUnityTypes + 1, fileName = "New GameObject - Game Event")]
    public class GameEventGameObject : ScriptableObject
    {
        public event Action<GameObject> OnEventRaised = delegate { };
        
        public void RaiseEvent(GameObject value)
        {
            OnEventRaised.Invoke(value);
        }
    }
}