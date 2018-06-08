using UnityEngine;

[ExecuteInEditMode]
public class Angle : MonoBehaviour {
    public Transform a;
    public Transform b;
    public float angleFromDot;
    public float angle;

    void Update ()
    {
        float dot = Vector3.Dot(a.position.normalized, b.position.normalized);
        angle = Vector3.Angle(a.position, b.position);
        angleFromDot = Mathf.Acos(dot) * Mathf.Rad2Deg;
        Debug.Log(angle + " " + angleFromDot + " " + dot);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawRay(Vector3.zero, a.position);
        Gizmos.DrawRay(Vector3.zero, b.position);
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(Vector3.zero, a.position.normalized);
        Gizmos.color = Color.Lerp(Color.yellow, Color.red, 0.5f);
        Gizmos.DrawRay(Vector3.zero, b.position.normalized);
        Gizmos.color = Color.grey;
    }
}
