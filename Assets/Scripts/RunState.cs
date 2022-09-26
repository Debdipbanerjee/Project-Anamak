using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RunState : StateBase
{
    public RunState(Character character, StateMachine stateMachine) : base(character, stateMachine)
    {

    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Run state");
    }

    public override void HandleInput()
    {
        base.HandleInput();
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 Direction = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        if (Direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(Direction.x, Direction.z) * Mathf.Rad2Deg;
            Character.transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            Character.Controller.Move(Direction * Character.speed * Time.deltaTime);
        }

    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        StateMachine.ChangeState(Character.IdleState);
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

    }

    public override void Exit()
    {
        base.Exit();
    }

}


