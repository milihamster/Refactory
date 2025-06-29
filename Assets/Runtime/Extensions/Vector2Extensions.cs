using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Refactory.Assets.Runtime.Extensions
{
    public static class Vector2Extensions
    {
        /// <summary>
        /// Converts a Vector2 to a Vector3 by adding a Z-Position.
        /// </summary>
        /// <param name="vector2">Input Vector2</param>
        /// <param name="z">Z-Position, default is 0</param>
        /// <returns>Converted Vector3</returns>
        public static Vector3 ToVector3(this Vector2 vector2, float z = 0f)
        {
            return new Vector3(vector2.x, vector2.y, z);
        }
    }
}
