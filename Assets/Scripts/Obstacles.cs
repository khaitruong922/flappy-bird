#pragma warning disable 0649
using UnityEngine;

public class Obstacles : MonoBehaviour
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
