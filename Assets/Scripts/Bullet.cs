using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    [SerializeField] private AnimationCurve acceleration;


    private void Update()
    {
        //Move ball in right direction
        //Multiply maxSpeed by Acceleration curve
    }

    private void OnCollisionEnter(Collision collision)
    {
        BulletPool.Instance.ReturnToPool(this);
        //Invoke camera shake effect
    }
}
