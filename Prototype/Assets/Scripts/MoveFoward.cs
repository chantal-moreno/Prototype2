using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    public float speed = 10.0f;
    public float spin = 250.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * spin);
        transform.position += new Vector3(0,0,1) * Time.deltaTime * speed;
    }
}