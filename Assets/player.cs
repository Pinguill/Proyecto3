using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour{
    public float speed = 4f;
    public Canvas battle;
    public Canvas UIEndGame;
    public float attackDamage;
    public float health;
    public float maxHealth;
    public Image healthImg;


    Animator anim;
    Rigidbody2D rb2d;
    Vector2 mov;


    // Start is called before the first frame update
    void Start(){
        battle.enabled = false;
        UIEndGame.enabled = false;
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update(){
        mov = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if(mov != Vector2.zero){
            anim.SetFloat("movX", mov.x);
            anim.SetFloat("movY", mov.y);
            anim.SetBool("walking", true);
        }
        else {
            anim.SetBool("walking", false);
        }

        healthImg.fillAmount = health / 100;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    void FixedUpdate(){
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }
    
    public void OnTriggerEnter2D( Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            GameObject busca = new GameObject();
            busca = GameObject.Find(other.gameObject.name);
            battle.enabled = true;
            BattleState obj = new BattleState();
            obj.dataEnemy(busca);
            
            Destroy(other.gameObject);
        }
    }

    public void curarse( float vidaACurar )
    {
        health += vidaACurar;
    }

    public void danioExtra( float dmgExtra)
    {
        attackDamage += dmgExtra;
    }

    public bool takeDamage(float dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
