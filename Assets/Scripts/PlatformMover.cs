using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    Transform[] points;

    [SerializeField]
    float velocity = 1.0f;

    int step = 0;
    float time = 0;

    [SerializeField]
    AnimationCurve movementCurve = new AnimationCurve(
        new Keyframe(0f, 0f),
        new Keyframe(1f, 1f)
    );

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        var start = points[step].position;
        var end = points[(step + 1) % points.Length].position;

        var dist = (end - start).magnitude;

        var lerpAmount = time * velocity / dist;

        if (lerpAmount > 1)
        {
            time = 0f;
            step = (step + 1) % points.Length;
        }

        if (rb != null)
        {
            rb.MovePosition(Vector3.Lerp(start, end, movementCurve.Evaluate(lerpAmount)));
        }
        else
        {
            transform.position = Vector3.Lerp(start, end, movementCurve.Evaluate(lerpAmount));
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (points == null || points.Length < 2)
            return;

        // Set the color of the lines
        Gizmos.color = Color.green;

        for (int i = 0; i < points.Length; i++)
        {
            Gizmos.DrawLine(points[i].position, points[(i + 1) % points.Length].position);
        }

    }
}
