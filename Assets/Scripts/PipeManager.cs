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
    private Vector3 lastPipePosition;
    private Vector3 lastGroundPosition;
    private void Start(){
        lastPipePosition=pipes[pipes.Length-1].transform.position;
        lastGroundPosition=grounds[grounds.Length-1].transform.position;
    }
    private void Update()
    {
        foreach (Transform p in pipes)
        {
            p.Translate(-moveSpeed * Time.deltaTime, 0, 0);
            if(p.transform.position.x <= resetPoint.transform.position.x)
            {
                p.transform.position = lastPipePosition;
            }
        }
        foreach (Transform g in grounds)
        {
            g.Translate(-moveSpeed * Time.deltaTime, 0, 0);
            if(g.transform.position.x <= resetPoint.transform.position.x)
            {
                g.transform.position = lastGroundPosition;
            }
        }
        
    }
}
