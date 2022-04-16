using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    public GameObject playerLight;
    float movementSpeed = 4f;
    float movementLimter = 0.7f;
    float inputVerticle;
    float inputHorizontal;
    Animator animator;
    string currentState;
    const string IDLE_DOWN = "idle_down";
    const string IDLE_UP = "idle_up";
    const string IDLE_SIDE = "idle_side";
    const string RUN_UP = "run_up";
    const string RUN_DOWN = "run_down";
    const string RUN_SIDE = "run_side";

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVerticle = Input.GetAxisRaw("Vertical");
    }

    public void TogglePlayerLight(bool isLight)
    {
        if (isLight)
        {
            playerLight.SetActive(true);
        }
        else
        {
            playerLight.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        if (inputHorizontal != 0 || inputVerticle != 0)
        {
            if (inputHorizontal != 0 && inputVerticle != 0)
            {
                inputHorizontal *= movementLimter;
                inputVerticle *= movementLimter;
            }

            rb.velocity = new Vector2(inputHorizontal * movementSpeed, inputVerticle * movementSpeed);

            if (inputHorizontal > 0)
            {
                spriteRenderer.flipX = true;
                AnimationStateChanger(RUN_SIDE);
            }
            else if (inputHorizontal < 0)
            {
                spriteRenderer.flipX = false;
                AnimationStateChanger(RUN_SIDE);
            }
            else if (inputVerticle > 0)
            {
                AnimationStateChanger(RUN_UP);
            }
            else if (inputVerticle < 0)
            {
                AnimationStateChanger(RUN_DOWN);
            }

        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
            AnimationStateChanger(IDLE_DOWN);
        }
    }

    void AnimationStateChanger(string newState)
    {
        if (currentState == newState) return;
        animator.Play(newState);
        currentState = newState;
    }
}
