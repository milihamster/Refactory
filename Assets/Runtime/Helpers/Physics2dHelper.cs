using UnityEngine;

namespace Refactory.Assets.Runtime.Helpers
{
    public static class Physics2dHelper
    {
        /// <summary>
        /// Checks if a given position is occupied by a physics object.
        /// </summary>
        /// <param name="targetPosition">Target Vector2 position</param>
        /// <param name="radius">Radius to check</param>
        /// <param name="layerMask">LayerMask to check</param>
        /// <returns></returns>
        public static bool CheckIfPositionIsOccupied(Vector2 targetPosition, float radius = 0.1f, int layerMask = ~0)
        {
            var hit = UnityEngine.Physics2D.OverlapCircle(targetPosition, radius, layerMask);
            return hit != null;
        }

        /// <summary>
        /// Checks if a given position is occupied by a physics object, with exception of ignoreGameObject.
        /// Usually used to check occupation by "anything but me".
        /// </summary>
        /// <param name="targetPosition">Target Vector2 position</param>
        /// <param name="ignoreGameObject">GameObject to ignore</param>
        /// <param name="radius">Radius to check</param>
        /// <param name="layerMask">LayerMask to check</param>
        /// <returns></returns>
        public static bool CheckIfPositionIsOccupied(Vector2 targetPosition, GameObject ignoreGameObject, float radius = 0.1f, int layerMask = ~0)
        {
            var colliders = UnityEngine.Physics2D.OverlapCircleAll(targetPosition, radius, layerMask);
            foreach (var collider in colliders)
            {
                if (collider != null && collider.gameObject != ignoreGameObject)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
