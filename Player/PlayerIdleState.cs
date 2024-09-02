using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState
{
    public PlayerIdleState(Player _player, PlayerStateMachine _playerStateMachine, string _animBoolName) : base(_player, _playerStateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        /*   if (xInput == player.facingDir && player.IsWallDetected())
           {
               return;
           }*/

        //Handle movement
        if (xInput != 0)
        {
            stateMachine.ChangeState(player.movementState);
        }
    }
}