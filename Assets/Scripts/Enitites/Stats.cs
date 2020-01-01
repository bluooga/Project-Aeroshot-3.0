using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public float Health;
    public string Entity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            YouAreDead();
        }
    }

    public void ImHit(float dmg)
    {
        Health -= dmg;
    }

    public void YouAreDead()
    {
        Destroy(gameObject);
    }
}
