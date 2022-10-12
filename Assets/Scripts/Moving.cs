using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.Timeline;

public class Moving : MonoBehaviour
{
    [Min(5f)]
    public float Speed = 0.1f;
    [Min(10f)]
    public float Distance = 5f;

    [HideInInspector]
    public bool IsStopped = false;

    private float dist = 0;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        var euler = transform.eulerAngles;
        euler.z = Random.Range(0.0f, 360.0f);
        transform.eulerAngles = euler;

        IsStopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsStopped) return;

        dist = Vector3.Distance(startPos, transform.position);
        IsStopped = !(dist < Distance);
        if (!IsStopped)
        {
            Vector3 delta = Speed * Time.deltaTime * new Vector3(1, 0, 0);
            transform.position += delta;
        }
    }
}
