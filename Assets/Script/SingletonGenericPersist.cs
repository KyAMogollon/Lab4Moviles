using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonGenericPersist<T> : MonoBehaviour
    where T : Component
{
    public static T Instance { get; private set; }
    public virtual void Awake()
    {
        if (Instance == null || Instance != null)
        {
            Instance = this as T;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
