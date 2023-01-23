using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    public float speed = 10.0f;
    private float spin = 250.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Projectile"))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * spin);
            transform.position += new Vector3(0,0,1) * Time.deltaTime * speed;
        }
        if (gameObject.CompareTag("Dog"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
