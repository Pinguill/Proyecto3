using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum battleState{ START, PLAYERTURN, ENEMYTURN, WON, LOST }


public class BattleState : MonoBehaviour
{
    public battleState state;
    float enemyAttack;
    GameObject jugador;
    GameObject enemigo;
    cobra unitEnemy;
    player unitPlayer;
    public Canvas UIBattle;
    public Canvas UIEndGame;

    // Start is called before the first frame update

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        enemigo = GameObject.FindGameObjectWithTag("Enemy");
        unitPlayer = jugador.GetComponent<player>();
        unitEnemy = enemigo.GetComponent<cobra>();
        state = battleState.START;
        setupBattle();
    }

    void setupBattle()
    {
        state = battleState.PLAYERTURN;
        turnPlayer();
    }

    public void dataEnemy( GameObject enemy )
    {
        enemigo = enemy;

        
        setupBattle();
    }

    void playerAttack()
    {
        bool dead = unitEnemy.takeDamage(unitPlayer.attackDamage);
        
        if (dead){
            state = battleState.WON;
            endBattle();
        }else{
            Debug.Log("Sigo viva");
            state = battleState.ENEMYTURN;
            enemyTurn(); 
        }
    }

    void enemyTurn()
    {
        bool dead = unitPlayer.takeDamage( unitEnemy.attackDamage );

        if (dead){
            state = battleState.LOST;
            endBattle();
        }else{
            state = battleState.PLAYERTURN;
            playerAttack();
        }
    }

    void endBattle()
    {
        if(state == battleState.WON)
        {
            UIBattle.enabled = false;
        }
        else if(state == battleState.LOST){
            UIBattle.enabled = true;
        }
    }

    void turnPlayer()
    {
    }


    public void attack1()
    {
        if (state != battleState.PLAYERTURN)
        {
            return;
        }
        playerAttack();
    }
}
