using UnityEngine;

[ExecuteInEditMode]
public class CrossProduct : MonoBehaviour {
    public Transform a;
    public Transform b;
    public float angleFromDot;
    public float angle;

    Vector3 cross = Vector3.zero;

    void Update ()
    {
        //float dot = Vector3.Dot(a.position.normalized, b.position.normalized);        
        cross = Vector3.Cross(a.position, b.position);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawRay(Vector3.zero, a.position);
        Gizmos.DrawRay(Vector3.zero, b.position);
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(Vector3.zero, a.position.normalized);
        Gizmos.color = Color.Lerp(Color.yellow, Color.red, 0.5f);
        Gizmos.DrawRay(Vector3.zero, b.position.normalized);
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Vector3.zero, cross);
        Gizmos.color = Color.grey;
    }
}
