using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyC : MonoBehaviour
{
    private void Start()
    {
        // var b = transform.parent;
        // print(b.name);
        
        transform.parent = null;
        // 캐릭터의 parent를 플랫폼으로 지정, 플랫폼에 올라타서 같이 이동됨
    }
}
