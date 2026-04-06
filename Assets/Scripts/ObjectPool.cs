using UnityEngine;

public abstract class ObjectPool<TObject, TOwner> : Singleton<TOwner>
    where TObject : MonoBehaviour
    where TOwner : MonoBehaviour
{
    //Here are the variables controlling the pool

    /// <summary>
    /// Create a pool here and increase it's size
    /// </summary>
    private void Start()
    {
        
    }

    /// <summary>
    /// Change this method  to virtual and write the default Implementation
    /// </summary>
    /// <returns></returns>
    public abstract TObject GetFromPool();

    /// <summary>
    /// Change this method  to virtual and write the default Implementation
    /// </summary>
    /// <returns></returns>
    public abstract void ReturnToPool(TObject @object);

    /// <summary>
    /// Write here the default Implementation
    /// </summary>
    private void IncreasePoolSize()
    {

    }
}
