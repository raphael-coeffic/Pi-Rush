using UnityEngine;
using TMPro;

[RequireComponent(typeof(Collider2D))]
public class CircleDigit : MonoBehaviour
{
    [SerializeField] private int digit = 3;
    [SerializeField] private bool isCorrect = true;
    [SerializeField] private TextMeshPro digitText;

    private bool alreadyHit = false;

    public void Init(int digitValue, bool correct)
    {
        digit = digitValue;
        isCorrect = correct;
        alreadyHit = false;

        if (digitText != null)
        {
            digitText.text = digit.ToString();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        if (alreadyHit) return;

        alreadyHit = true;

        if (isCorrect)
            GameManager.Instance.OnCorrectCircleHit(transform);
        else
            GameManager.Instance.OnWrongCircleHit();
    }
}

