using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// public class StudyA : MonoBehaviour
// {
//     //public GameObject studyBGameObject;
//     private GameObject studyBGameObject;
//
//     private void Start()
//     {
//         //studyBGameObject = GameObject.Find("B");    // 제일 처음 검색된 B 반환
//         studyBGameObject = GameObject.FindObjectOfType<StudyB>().gameObject;   // FindObjectOfType<>은 컴포넌트를 반환
//         print(studyBGameObject.name);
//     }
// }

//////////////////////////////////////////////////

// B를 새로 만드는 경우
// 실행을 멈추면 B는 다시 사라진다
// public class StudyA : MonoBehaviour
// {
//     private GameObject studyBGameObject;
//
//     private void Start()
//     {
//         studyBGameObject = new GameObject(name: "B");
//         studyBGameObject.AddComponent<StudyB>();
//         print(studyBGameObject.name);
//         
//         //Destroy(studyBGameObject);
//
//         var studyB = studyBGameObject.GetComponent<StudyB>();
//         studyB.SendMessage(methodName:"SayHello");
//         
//         // 게임오브젝트 자체에 보내는 경우
//         studyBGameObject.SendMessage(methodName:"SayHello");
//         // 게임오브젝트에 다른 컴포넌트가 더 붙어있는 경우
//         // ex) StudyC의 SayHello -> "C에서 인사"
//         // StudyB의 SayHello, StudyC의 SayHello 모두 실행됨
//     }
// }

//////////////////////////////////////////////////

public class StudyA : MonoBehaviour
{
    private void Start()
    {
        var c = transform.Find("B/C");  // 계층구조를 찾을 수도 있다
        print(c.name);
    }
}