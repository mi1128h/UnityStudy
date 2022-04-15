using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator _animator;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private bool _isAttacking;
    
    void OnAttack()
    {
        if(!_isAttacking)
            StartCoroutine(AttackRoutine());
    }

    IEnumerator AttackRoutine()
    {
        _animator.SetBool("IsAttack", true);
        _isAttacking = true;
        yield return new WaitForSeconds(1.5f);
        _animator.SetBool("IsAttack", false);
        _isAttacking = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
