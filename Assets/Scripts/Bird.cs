#pragma warning disable 0649
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float flapHeight;
    private bool inputJumpDown;
    private Vector3 startPosition;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        startPosition = transform.position;
    }
    private void FixedUpdate()
    {

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, flapHeight);

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
    private void OnTriggerEnter2D(Collider2D other)
    {
        IScoreAdder scoreAdder = other.GetComponent<IScoreAdder>();
        if (scoreAdder != null)
        {
            scoreAdder.AddScore();
        }
        else
        {
            GameManager.Instance.StopGame();
        }
    }
}
