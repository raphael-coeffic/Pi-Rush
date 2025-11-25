using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothSpeed = 5f;
    [SerializeField] private float yOffset = 0f;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 pos = transform.position;
        float targetY = target.position.y + yOffset;
        pos.y = Mathf.Lerp(pos.y, targetY, smoothSpeed * Time.deltaTime);
        transform.position = pos;
    }
}

