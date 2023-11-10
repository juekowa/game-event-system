using System;
using UnityEngine;

namespace GameEventSystem
{
    [CreateAssetMenu(menuName = OrderMode.MenuUnityTwoParameters + "GameObject, GameObject", order = OrderMode.LevelUnityTwoParameters + 1, fileName = "New GameObject, GameObject - Game Event")]
    public class GameEventGameObjectGameObject : ScriptableObject
    {
        public event Action<GameObject, GameObject> OnEventRaised = delegate { };
        
        public void RaiseEvent(GameObject value1, GameObject value2)
        {
            OnEventRaised.Invoke(value1, value2);
        }
    }
}