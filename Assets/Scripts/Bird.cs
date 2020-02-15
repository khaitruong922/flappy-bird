#pragma warning disable 0649
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float flapHeight;
    [SerializeField]
    private AudioSource flap, score, hit;
    private void Awake()
    {

    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {

    }
    private void Update()
    {
        if (GameManager.Instance.IsGamePaused)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, flapHeight);
            flap.Play();

        }
        if (rb.velocity.y >= 0)
        {
            rb.rotation = 30f;
        }
        else
        {
            rb.rotation = -30f;
        }
    }
    public void Die()
    {
        GameManager.Instance.End();
        hit.Play();
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        GameManager.Instance.AddScore();
        score.Play();
    }
}
