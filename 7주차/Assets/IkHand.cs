using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkHand : MonoBehaviour
{
    private Animator _animator;

    public Transform handPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        _animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
        _animator.SetIKPosition(AvatarIKGoal.RightHand, handPosition.position);
        _animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
        _animator.SetIKRotation(AvatarIKGoal.RightHand, handPosition.rotation);
    }
}
