using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float launchForce = 8f;

    private Rigidbody2D rb;
    private Vector2 dragStartWorld;
    private bool isDragging = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Mouse.current == null) return;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            dragStartWorld = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            isDragging = true;
        }

        if (Mouse.current.leftButton.wasReleasedThisFrame && isDragging)
        {
            Vector2 dragEndWorld = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            Vector2 direction = dragStartWorld - dragEndWorld;

            rb.linearVelocity = Vector2.zero;
            rb.AddForce(direction * launchForce, ForceMode2D.Impulse);

            isDragging = false;
        }

        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        bool outOfBounds =
            viewPos.x < 0f || viewPos.x > 1f ||
            viewPos.y < 0f || viewPos.y > 1f;

        if (outOfBounds)
        {
            GameManager.Instance.OnMissedTarget();
        }
    }
}
