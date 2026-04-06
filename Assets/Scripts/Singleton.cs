using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    //Invoke somewhere creation of Singleton Instance

    public abstract T CreateInstance();
}
