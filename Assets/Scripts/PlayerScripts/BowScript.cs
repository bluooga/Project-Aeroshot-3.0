using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowScript : MonoBehaviour
{
    public float Charge;
    public float ChargeRate;
    public float MaxCharge;

    public KeyCode ChargeKey;

    public Transform Spawn;
    public Rigidbody Arrow;
    public Animator BowAnimator;

    // Start is called before the first frame update
    void Start()
    {
        BowAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(ChargeKey) && Charge < MaxCharge)
        {
            Charge += ChargeRate * Time.deltaTime;
            BowAnimator.SetBool("IsCharging", true);
        }

        if(Charge > MaxCharge)
        {
            Charge = MaxCharge;
        }

        if (Input.GetKeyUp(ChargeKey))
        {
            FireArrow(Charge);
            BowAnimator.SetBool("IsCharging", false);
        }
    }

    public void FireArrow(float force)
    {
        Rigidbody arrow = Instantiate(Arrow, Spawn.position, transform.rotation) as Rigidbody;
        arrow.GetComponent<ArrowScript>().Damage = force;
        arrow.AddForce(Spawn.forward * force, ForceMode.Impulse);
        Destroy(arrow.gameObject, 10);

        Charge = 0;
    }
}
