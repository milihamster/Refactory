using UnityEngine;

namespace Refactory.Managers
{
    /// <summary>
    /// Allows inheriting classes to be called at any time, anywhere,
    /// independent from wether an instance of the class exists in the scene or not.
    /// An object of this class will be created automatically when it's called.
    /// </summary>
    /// <typeparam name="T">Inheriting Class (e. g. AudioManager)</typeparam>
    public abstract class BaseManager<T> : MonoBehaviour where T : BaseManager<T>
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    // Find existing instance in the scene
                    _instance = FindFirstObjectByType<T>();

                    // Create a new instance if one doesn't already exist
                    if (_instance == null)
                    {
                        GameObject singletonObject = new GameObject("Manager");
                        _instance = singletonObject.AddComponent<T>();

                        // Make sure it persists between scenes
                        DontDestroyOnLoad(singletonObject);
                    }
                }
                return _instance;
            }
        }

        protected void Awake()
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
                // Set name so the manager is easily identifiable
                name = this.GetType().Name;
            }
        }
    }
}
