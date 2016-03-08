using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public float speed = 100;


    private Vector2 direction = Vector2.zero;
    private Animator animator;
    private static int WalkLeft = Animator.StringToHash("Base Layer.Left");
    private static int WalkRight = Animator.StringToHash("Base Layer.Right");
    private static int WalkUp = Animator.StringToHash("Base Layer.Top");
    private static int WalkDown = Animator.StringToHash("Base Layer.Bot");
    private static int Idle = Animator.StringToHash("Base Layer.Idle");

    //   private static int Left = Animator.StringToHash("Base Layer.IdleLeft");
    //  private static int Right = Animator.StringToHash("Base Layer.IdleRight");
    //   private static int Up = Animator.StringToHash("Base Layer.IdleUp");
    //   private static int Down = Animator.StringToHash("Base Layer.IdleDown");

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        direction.Normalize();

        AnimatorStateInfo info = animator.GetCurrentAnimatorStateInfo(0);
        if (direction.y == 1)
        {
            animator.Play(WalkUp);
        }
        else if (direction.y == -1)
        {
            animator.Play(WalkDown);
        }
        else if (direction.x == 1)
        {
            animator.Play(WalkRight);
        }
        else if (direction.x == -1)
        {
            animator.Play(WalkLeft);
        }
        else
        {

            animator.Play(Idle);
        }

        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
