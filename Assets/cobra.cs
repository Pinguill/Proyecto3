using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cobra : MonoBehaviour
{
    private bool FightEnabled;
    public float vidaMax;
    public float vida;
    public float visionRadius;
    public float attackRadius;
    public float speed;
    public float attackDamage;

    GameObject player;

    Vector3 initialPosition;

    Animator anim;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        initialPosition = transform.position;

        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        vida = vidaMax;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = initialPosition;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, player.transform.position - transform.position, visionRadius, 1 << LayerMask.NameToLayer("Default"));

        Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
        Debug.DrawLine(transform.position, forward, Color.red);

        if (hit.collider != null)
        {
            if(hit.collider.tag == "Player")
            {
                target = player.transform.position;
            }
        }

        float distance = Vector3.Distance(target, transform.position);
        Vector3 dir = (target - transform.position).normalized;

        if(target != initialPosition && distance < attackRadius)
        {
            anim.SetFloat("movX", dir.x);
            anim.SetFloat("movY", dir.y);
            anim.Play("cobra_move", -1, 0);
        }
        else
        {
            rb2d.MovePosition(transform.position + dir * speed * Time.deltaTime);

            anim.speed = 1;
            anim.SetFloat("movX", dir.x);
            anim.SetFloat("movY", dir.y);
            anim.SetBool("walking", true);
        }

        if(target == initialPosition && distance < 0.02f)
        {
            transform.position = initialPosition;

            anim.SetBool("walking", false);
        }
        Debug.DrawLine(transform.position, target, Color.green);

        if(vida > vidaMax)
        {
            vida = vidaMax;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadius);
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }

    public bool takeDamage( float dmg )
    {

        Debug.Log("Take damage cobra: "+ dmg);
        vida -= dmg;
        if (vida <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}
