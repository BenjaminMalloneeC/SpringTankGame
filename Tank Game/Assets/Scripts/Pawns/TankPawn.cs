using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : Pawn
{

    #region Variables
    public Shooter shooter;
    public GameObject shellPrefab;
    public float fireForce;
    public float damageDone;
    public float lifeSpan;
    #endregion Variables

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        shooter = GetComponent<Shooter>();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    #region Movement

    public override void MoveForward()
    {
        //Debug.Log("Moving forward " + moveSpeed);
        mover.Move(transform.forward, moveSpeed);
    }

    public override void MoveBackward()
    {
        //Debug.Log("Moving backward " + moveSpeed);
        mover.Move(transform.forward, -moveSpeed);
    }

    public override void RotateClockwise()
    {
        //Debug.Log("Rotating clockwise " + turnSpeed);
        mover.Rotate(turnSpeed);
    }

    public override void RotateCounterClockwise()
    {
        //Debug.Log("Rotating counterclockwise " + turnSpeed);
        mover.Rotate(-turnSpeed);
    }

    #endregion Movement

    public override void Shoot()
    {
        shooter.Shoot(shellPrefab, fireForce, damageDone, lifeSpan);
    }

}
