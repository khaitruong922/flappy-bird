#pragma warning disable 0649
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private void Update()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
    }
}
