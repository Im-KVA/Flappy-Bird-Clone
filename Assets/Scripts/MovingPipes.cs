using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPipes : MonoBehaviour
{
    [SerializeField] private float speed = 0.65f;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
