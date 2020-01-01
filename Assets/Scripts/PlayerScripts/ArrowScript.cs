using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public float Damage;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(rb.velocity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<ArrowScript>() == null)
        {
            Destroy(this);
            Destroy(rb);
        }

        if (collision.gameObject.GetComponent<Stats>() != null)
        {
            collision.gameObject.GetComponent<Stats>().ImHit(Damage);
            Destroy(gameObject);
        }

    }
}
