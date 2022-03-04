﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Problem_2_weapon_.SingleTon
{
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        private static T instance = null;

        public static T Instance
        {
            get
            {
                instance = instance ?? (FindObjectOfType(typeof(T)) as T);
                instance = instance ?? new GameObject(typeof(T).ToString(), typeof(T)).GetComponent<T>();
                return instance;
            }
        }
        private void OnApplicationQuit()
        {
            instance = null;
        }
    }
}