using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingGround : MonoBehaviour
{
    [SerializeField] private float speed = 1f; 
    private float width; 

    private void Start()
    {
        BoxCollider2D floorCollider = GetComponent<BoxCollider2D>();
        width = floorCollider.size.x;
    }

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x <= -width)
        {
            Vector3 newPos = new Vector3(transform.position.x + 2 * width, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
