using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = "Game Events/GameObject, GameObject", order = 151, fileName = "New GameObject, GameObject - Game Event")]
    public class GameEventGameObjectGameObject : ScriptableObject
    {
        public event Action<GameObject, GameObject> OnEventRaised = delegate { };
        
        public void RaiseEvent(GameObject value1, GameObject value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}