using UnityEngine;

public class CameraController : Singleton<CameraController>
{
    [SerializeReference, SubclassSelector] private CameraEffect[] defaultParameters;

    public override CameraController CreateInstance() => this;

    //Write here a method for CameraShake Effect
}
