using Refactory.Assets.Runtime.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Refactory.Assets.Runtime.Extensions
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Trys to get a component, or adds it if it doesn't exist.
        /// </summary>
        /// <typeparam name="T">Component type</typeparam>
        /// <param name="targetGameObject">Target GameObject to add the component to.</param>
        /// <returns>Found or newly created component.</returns>
        public static T GetOrAddComponent<T>(this GameObject targetGameObject) where T : Component
        {
            return targetGameObject.TryGetComponent<T>(out var comp) ? comp : targetGameObject.AddComponent<T>();
        }

        /// <summary>
        /// Destroys all children of a GameObject, without destroying the gameObject itself.
        /// </summary>
        /// <param name="targetGameObject">Target GameObject</param>
        public static void DestroyChildren(this GameObject targetGameObject)
        {
            targetGameObject.transform.DestroyChildren();
        }

        /// <summary>
        /// Checks if a GameObject has a specific component.
        /// </summary>
        /// <typeparam name="T">Component type</typeparam>
        /// <param name="targetGameObject">Target GameObject</param>
        /// <returns>True if component was found on the GameObject.</returns>
        public static bool HasComponent<T>(this GameObject targetGameObject) where T : Component
        {
            return targetGameObject.TryGetComponent<T>(out _);
        }

        /// <summary>
        /// Moves a GameObject to to the current mouse position.
        /// </summary>
        /// <param name="targetGameObject">Target GameObject</param>
        public static void MoveToMousePos(this GameObject targetGameObject)
        {
            targetGameObject.MoveToMousePos();
        }

        /// <summary>
        /// Checks if the given position is occupied by anything but the given GameObject.
        /// </summary>
        /// <param name="targetGameObject">Target GameObject</param>
        public static bool CheckIfPositionIsOccupied(this GameObject targetGameObject)
        {
            return Physics2dHelper.CheckIfPositionIsOccupied(targetGameObject.transform.position, targetGameObject);
        }
    }
}
