using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{

    public float LookRange;
    public float AttackRange;
    public float Dmg;

    Transform Target;
    NavMeshAgent Agent;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Target = PlayerManager.instance.player.transform;
        Agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Target.position, transform.position);

        if (distance <= LookRange)
        {
            Agent.SetDestination(Target.position);
            animator.SetBool("IsWalking", true);

            if (distance <= Agent.stoppingDistance)
            {
                FaceTarget();
            }
        }

        if (distance > LookRange)
        {
            animator.SetBool("IsWalking", false);
        }
    }

    void FaceTarget()
    {
        Vector3 Direction = (Target.position - transform.position).normalized;
        Quaternion LookRotation = Quaternion.LookRotation(new Vector3(Direction.x, 0, Direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, LookRotation, Time.deltaTime * 5f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRange);

        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, AttackRange);
    }
}
