using UnityEngine;

namespace Refactory.Assets.Runtime.Extensions
{
    public static class TransformExtensions
    {
        /// <summary>
        /// Destroys all children of a Transform, without destroying the gameObject itself.
        /// </summary>
        /// <param name="targetTransform">Target Transform</param>
        public static void DestroyChildren(this Transform targetTransform)
        {
            foreach (Transform child in targetTransform)
                UnityEngine.Object.Destroy(child.gameObject);
        }

        /// <summary>
        /// Moves a Transform to to the current mouse position.
        /// </summary>
        /// <param name="targetTransform">Target Transform</param>
        public static void MoveToMousePos(this Transform targetTransform)
        {
            if (Camera.main == null) 
                return;

            var mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane; // Set Z to near clip plane
            var worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            // Move the transform to the world position
            Transform transform = Camera.main.transform;
            targetTransform.position = new Vector3(worldPos.x, worldPos.y, targetTransform.position.z);
        }
    }
}
