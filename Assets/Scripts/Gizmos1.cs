using UnityEngine;

public class Gizmos1 : MonoBehaviour
{
    public float explosionRadius = 5.0F;
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(transform.position, explosionRadius);
    }
}
