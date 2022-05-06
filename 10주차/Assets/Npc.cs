using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Npc : MonoBehaviour
{
    private NavMeshAgent _agent;
    private NpcState _npcState;
    public float sightAngle = 45f;
    public float sightRange = 2f;
    public Transform target;
    
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        EventManager.Instance.Subscribe("game_over", OnGameOver);
    }
    
    private void OnEnable()
    {
        StartCoroutine(NpcRoutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private void OnGameOver(object param)
    {
        gameObject.SetActive(false);
    }

    IEnumerator NpcRoutine()
    {
        _npcState = NpcState.Finding;
        
        while (true)
        {
            switch (_npcState)
            {
                case NpcState.Finding:
                    yield return Find();
                    break;
                case NpcState.Chasing:
                    yield return Chase();
                    break;
                case NpcState.Attacking:
                    yield return Attack();
                    break;
            }
            yield return null;
        }
    }

    IEnumerator Find()
    {
        // 랜덤 위치로 돌아다님
        var dir = Random.insideUnitSphere;
        var dest = dir * 5f + transform.position;
        NavMesh.SamplePosition(dest, out var hit, 5f, NavMesh.AllAreas);
        _agent.destination = hit.position;

        while (_agent.remainingDistance > 0.1f)
        {
            // 시야각에 타겟이 들어옴
            var dirFromTarget = (target.position - transform.position).normalized;
            var dot = Vector3.Dot(dirFromTarget, transform.forward);
            var degree = Mathf.Acos(dot) * Mathf.Rad2Deg;

            Physics.Raycast(transform.position, transform.forward, out var hitInfo);

            if (hitInfo.collider != null &&
                hitInfo.collider.gameObject.name == "Target" && 
                degree < sightAngle &&
                Vector3.Distance(target.position, transform.position) < sightRange)
            {
                _npcState = NpcState.Chasing;
                break;
            }
            
            yield return null;
        }
    }

    IEnumerator Chase()
    {
        while (_agent.remainingDistance > 0.1f)
        {
            _agent.destination = target.position;
            yield return null;
        }

        _npcState = NpcState.Attacking;
    }

    IEnumerator Attack()
    {
        while (_agent.remainingDistance < 0.1f)
        {
            _agent.destination = target.position;
            print("Attack!!!");
            yield return null;
        }

        _npcState = NpcState.Finding;
    }
}
