using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterScript : MonoBehaviour
{
    private int inputedKey;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { animator.SetInteger("AnimNumber", 1); }
        if (Input.GetKeyDown(KeyCode.Alpha2)) { animator.SetInteger("AnimNumber", 2); }
        if (Input.GetKeyDown(KeyCode.Alpha3)) { animator.SetInteger("AnimNumber", 3); }
        if (Input.GetKeyDown(KeyCode.Alpha4)) { animator.SetInteger("AnimNumber", 4); }
        if (Input.GetKeyDown(KeyCode.Alpha5)) { animator.SetInteger("AnimNumber", 5); }
    }
}
