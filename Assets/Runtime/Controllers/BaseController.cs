using UnityEngine;

namespace Refactory.Controllers
{
    /// <summary>
    /// Allows inheriting Classes to be called at any times, anywhere
    /// An object of this class will be created automatically when it's called.
    /// </summary>
    /// <typeparam name="T">Inheriting Class (e. g. AudioController)</typeparam>
    public abstract class BaseController<T> : MonoBehaviour where T : BaseController<T>
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    // Find existing instance in the scene
                    _instance = FindObjectOfType<T>();

                    // Create a new instance if one doesn't already exist
                    if (_instance == null)
                    {
                        GameObject singletonObject = new GameObject("Controller");
                        _instance = singletonObject.AddComponent<T>();

                        // Make sure it persists between scenes
                        DontDestroyOnLoad(singletonObject);
                    }
                }
                return _instance;
            }
        }

        private void Awake()
        {
            // If another instance exists, destroy it
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                _instance = (T)this;
                DontDestroyOnLoad(gameObject);
                // Set name so the controller is easily identifiable
                name = this.GetType().Name;
            }
        }
    }
}
