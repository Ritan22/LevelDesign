using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.125f;
    [SerializeField] private Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    private bool hasBeenAssigned;

    // Start is called before the first frame update
    void Start()
    {
        hasBeenAssigned = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target == null && hasBeenAssigned) return;
        if (target == null)
        {
            GameObject newTarget = GameObject.FindGameObjectsWithTag("Player")[0];
            target = newTarget.transform;
        }
        else
        {
            if (!hasBeenAssigned)
                hasBeenAssigned = true;
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}
