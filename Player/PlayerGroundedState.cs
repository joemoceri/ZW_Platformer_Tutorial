using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerGroundedState : PlayerState
{
    public PlayerGroundedState(Player _player, PlayerStateMachine _playerStateMachine, string _animBoolName) : base(_player, _playerStateMachine, _animBoolName)
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


        if (!player.IsGroundDetected())
        {
            stateMachine.ChangeState(player.airState);
        }



        if (Input.GetKeyUp(KeyCode.Space) && player.IsGroundDetected())
        {
            stateMachine.ChangeState(player.jumpState);
        }

      /*  if (Input.GetKeyUp(KeyCode.K))
        {
            stateMachine.ChangeState(player.primaryAttackState);
        }
*/

    }
}