using UnityEngine;

public class BulletPool : ObjectPool<Bullet, BulletPool>
{
    public override BulletPool CreateInstance() => this;

    /// <summary>
    /// Remove later this method when ObjectPool will have its definition
    /// </summary>
    /// <returns></returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public override Bullet GetFromPool()
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// Remove later this method when ObjectPool will have its definition
    /// </summary>
    /// <returns></returns>
    /// <exception cref="System.NotImplementedException"></exception>
    public override void ReturnToPool(Bullet @object)
    {
        throw new System.NotImplementedException();
    }
}