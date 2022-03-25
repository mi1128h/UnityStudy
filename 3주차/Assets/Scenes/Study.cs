using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [Serializable]
// public class ComplexType
// {
//     public string name;
//     public int age;
//     public float height;
// }
//
// public class Study : MonoBehaviour
// {
//     public ComplexType studyName;
//     
//     // Start is called before the first frame update
//     void Start()
//     {
//         print(message:"게임이 시작되었습니다.");
//     }
//
//     private void OnEnable()
//     {
//         print(message:"컴포넌트가 활성화 되었습니다.");
//     }
//
//     private void OnDisable()
//     {
//         print(message:"컴포넌트가 비활성화 되었습니다.");
//     }
//     
//     // Update is called once per frame
//     void Update()
//     {
//         print(message:"컴포넌트가 업데이트 되었습니다.");
//     }
//     
//     // 똑같은 인터벌로 실행됨
//     // 물리적인 연산, 똑같은 주기로 실행되어야 할 때
//     private void FixedUpdate()
//     {
//         print(message:"컴포넌트가 주기적으로 업데이트 됩니다.");
//     }
//
//     // 카메라 이동시켜야 할 때
//     // 사용자 인풋 연산에 대한 결과값이 표시되어야 할 때
//     // Update 뒤에 실행됨
//     private void LateUpdate()
//     {
//         print(message:"업데이트 뒤에 실행 됩니다.");
//     }
// }

/////////////////////////////////////////////////

// 타이머를 이용한 로직
// public class Study : MonoBehaviour
// {
//     private const float AttackInterval = 3f;
//
//     private float _attackIntervalTimer;
//
//     private void Update()
//     {
//         _attackIntervalTimer += Time.deltaTime;
//
//         if (_attackIntervalTimer > 3f)
//         {
//             PrintText();
//             _attackIntervalTimer = 0f;
//         }
//     }
//
//     void PrintText()
//     {
//         print(message:"공격!!!");
//     }
// }

/////////////////////////////////////////////////

public class Study : MonoBehaviour
{
    private void Start()
    {
        //Invoke(methodName:"PrintText", time:3f);  // 언리얼 딜레이
        InvokeRepeating(methodName:"PrintText", time:9f, repeatRate:3f);    // 반복작업
    }

    void PrintText()
    {
        print(message:"공격!!!");
    }
}