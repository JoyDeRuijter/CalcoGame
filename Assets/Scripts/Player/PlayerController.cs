using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private LayerMask objectsSolidLayer;
    private bool isMoving;
    private Vector2 input;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        HandleMovement();
    }

    //IEnumerator that smoothly moves the player to the given targetposition
    IEnumerator Move(Vector3 _targetPos)
    {
        isMoving = true;

        while ((_targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
        transform.position = _targetPos;

        isMoving = false;
    }

    //Bool that returns true if the targetposition is walkable and false if it isn't
    private bool IsWalkable(Vector3 _targetPos)
    {
        Vector3 targetPos = new Vector3(_targetPos.x, _targetPos.y + 0.5f, _targetPos.z);
        if (Physics2D.OverlapCircle(targetPos, 0.2f, objectsSolidLayer) != null)
            return false;
        return true;
    }

    //Handles the playermovement by using the axis-input and checking if the player SHOULD and CAN move
    private void HandleMovement()
    {
        if (!isMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if (input.x != 0) input.y = 0;

            if (input != Vector2.zero)
            {
                anim.SetFloat("moveX", input.x);
                anim.SetFloat("moveY", input.y);

                Vector2 targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;

                if (IsWalkable(targetPos))
                    StartCoroutine(Move(targetPos));
            }
        }
        anim.SetBool("isMoving", isMoving);
    }
}
