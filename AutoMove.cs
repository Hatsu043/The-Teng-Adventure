using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 newPosition;
    public int speed;
    public int maxDistance;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.y = startPosition.y + (maxDistance * Mathf.Sin(Time.time * speed));
        transform.position = newPosition;
    }
}
