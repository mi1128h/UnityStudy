using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public int count;
    public Mesh mesh;
    public Material[] materials;

    private List<List<Matrix4x4>> _batches;

    void Start()
    {
        _batches = new List<List<Matrix4x4>>();
        var addedMatrices = 0;
        
        for (int i = 0; i < count; i++)
        {
            if (addedMatrices < 1000 && _batches.Count != 0)
            {
                _batches[_batches.Count - 1].Add(Matrix4x4.TRS(
                        new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f)),
                        Quaternion.identity,
                        Vector3.one
                    )
                );
                addedMatrices += 1;
            }
            else
            {
                _batches.Add(new List<Matrix4x4>());
                addedMatrices = 0;
            }
        }
    }

    void Update()
    {
        foreach (var batch in _batches)
        {
            for (int i = 0; i < mesh.subMeshCount; ++i)
            {
                Graphics.DrawMeshInstanced(mesh, i, materials[i], batch);
            }
        }
    }
}
