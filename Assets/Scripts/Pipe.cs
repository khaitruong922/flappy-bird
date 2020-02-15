#pragma warning disable 0649
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Bird bird = other.gameObject.GetComponent<Bird>();
        if(bird!= null)
        {
            bird.Die();
        }
    }
}
