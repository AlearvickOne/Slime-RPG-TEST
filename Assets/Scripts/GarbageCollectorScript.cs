using System;
using System.Collections;
using UnityEngine;

public class GarbageCollectorScript : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = -1;
        StartCoroutine(ClearMemory());
    }

    private IEnumerator ClearMemory()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            GC.Collect(1, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
        }
    }
}
