using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Cube;

    [Min(1f)]
    public float ReloadTimeSec = 2f;
    private float elapsed = 0f;
    private readonly List<GameObject> cubes = new List<GameObject>();

    void ClearCubes()
    {
        for (int i = cubes.Count - 1; i>=0; i--)
        {
            GameObject cube = cubes[i];
            Moving mv = cube.GetComponentInChildren<Moving>();
            if (mv.IsStopped)
            {
                cubes.Remove(cube);
                Destroy(cube);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.unscaledDeltaTime;
        if (elapsed >= ReloadTimeSec)
        {
            elapsed = 0;
            var a = Instantiate(Cube);
            cubes.Add(a);
        }
        ClearCubes();
    }
}
