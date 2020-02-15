#pragma warning disable 0649
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float difficulty;
    [SerializeField]
    private Transform[] pipes;
    [SerializeField]
    private Transform[] grounds;

    [SerializeField]
    private Transform pipeStart, pipeEnd, groundStart, groundEnd;
    private void Start()
    {
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i].transform.position += new Vector3(0, Random.Range(-difficulty, difficulty));
        }
    }
    private void Update()
    {
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i].Translate(-moveSpeed * Time.deltaTime, 0, 0);

            if (pipes[i].transform.position.x <= pipeEnd.position.x)
            {
                pipes[i].transform.position = pipeStart.position + new Vector3(0, Random.Range(-difficulty, difficulty), 0);
            }
        }
        for (int i = 0; i < grounds.Length; i++)
        {
            grounds[i].Translate(-moveSpeed * Time.deltaTime, 0, 0);

            if (grounds[i].transform.position.x <= groundEnd.position.x)
            {
                grounds[i].transform.position = groundStart.position;
            }
        }
    }
}
