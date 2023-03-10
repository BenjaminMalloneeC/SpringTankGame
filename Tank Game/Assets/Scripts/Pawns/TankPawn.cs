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
    }

    // A move forward function
    public override void MoveForward()
    {
        mover.Move(transform.forward, moveSpeed);
    }

    // A move backward function
    public override void MoveBackward()
    {
        mover.Move(transform.forward, -moveSpeed);
    }

    // A rotate clockwise function
    public override void RotateClockwise()
    {
        mover.Rotate(turnSpeed);
    }

    // A rotate counterclockwise function
    public override void RotateCounterClockwise()
    {
        mover.Rotate(-turnSpeed);
    }

    public override void RotateTowards(Vector3 targetPosition)
    {
        // Find the vector to our target position 
        Vector3 vectorToTarget = targetPosition - transform.position;

        // Find the rotation to look down that vector
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);

        // Rotate closer to that vector
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }

    public override void Shoot()
    {
        shooter.Shoot(shellPrefab, fireForce, damageDone, lifeSpan);
    }

}
