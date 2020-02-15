#pragma warning disable 0649
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private Transform[] pipes;
    [SerializeField]
    private Transform resetPoint;
    [SerializeField]
    private Transform[] grounds;
    [SerializeField]
    private Transform skyBounds;
    private void Update()
    {
        foreach (Transform p in pipes)
        {
            p.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        foreach (Transform g in grounds)
        {
            g.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
        
    }
}
