using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrimaryAttackState : PlayerState
{
    // property
    public int comboCounter { get; private set; }
    private float comboWindow = .5f;
    private float lastTimeAttacked;

    public PlayerPrimaryAttackState(Player _player, PlayerStateMachine _playerStateMachine, string _animBoolName) : base(_player, _playerStateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        //AudioManager.instance.PlaySFX(2, null); // attack sound effect

        xInput = 0;  // we need this to fix bug on attack direction

        if (comboCounter > 3 || Time.time >= lastTimeAttacked + comboWindow)
            comboCounter = 0;

        player.Anim.SetInteger("ComboCounter", comboCounter);


        float attackDir = player.facingDir;

        if (xInput != 0)
            attackDir = xInput;


        player.attackDetails.attackLevel = 1;
    }


    public override void Exit()
    {
        base.Exit();
        //player.StartCoroutine("BusyFor", .15f);
        comboCounter++;
        lastTimeAttacked = Time.time;
    }

    public override void Update()
    {
        base.Update();

        if (stateTimer < 0)
        {
            player.SetZeroVelocity();
        }

        if (triggerCalled)
        {
            stateMachine.ChangeState(player.idleState);
        }
    }
}