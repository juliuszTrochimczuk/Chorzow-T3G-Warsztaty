using System;
using UnityEngine;

/// <summary>
/// Class used for Unity Editor
/// </summary>
[Serializable]
public abstract class CameraEffect
{
    [field: SerializeField] public float Duration { get; private set; }
    public abstract Type CinemacineComponentType { get; }

    public abstract void OnTransitionStart();
    
    public abstract void OnTransitionUpdate(float progress);
    
    public abstract void OnTransitionEnd();
    public abstract void SetCinemachineComponent(MonoBehaviour component);
}

/// <summary>
/// Class that all camera effects inherites
/// </summary>
/// <typeparam name="T"></typeparam>
[Serializable]
public abstract class CameraEffect<T> : CameraEffect where T : MonoBehaviour
{
    protected T CinemachineComponent { get; private set; }

    public override Type CinemacineComponentType => typeof(T);

    public override void SetCinemachineComponent(MonoBehaviour component)
    {
        if (!component.GetType().Namespace.Contains("Cinemachine"))
            throw new ArgumentException($"{component} is not a Cinemachine component");
        CinemachineComponent = (T)component;
    }
}
