using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject circlePrefab;
    [SerializeField] private float horizontalOffset = 1.5f;
    [SerializeField] private float verticalOffset = 4f;

    public void SpawnNewSetFromBase(Vector3 basePosition, int digitIndex)
    {
        var oldCircles = GameObject.FindGameObjectsWithTag("Circle");
        foreach (var c in oldCircles)
            Destroy(c);

        int correctDigit = PiDigits.GetDigit(digitIndex);
        int correctIndex = Random.Range(0, 2);

        for (int i = 0; i < 2; i++)
        {
            float xOffset = (i == 0 ? -horizontalOffset : horizontalOffset);
            Vector3 spawnPos = basePosition + new Vector3(xOffset, verticalOffset, 0f);

            GameObject circle = Instantiate(circlePrefab, spawnPos, Quaternion.identity);
            circle.tag = "Circle";

            bool isCorrect = (i == correctIndex);

            int digitValue;
            if (isCorrect)
            {
                digitValue = correctDigit;
            }
            else
            {
                digitValue = Random.Range(0, 10);
                while (digitValue == correctDigit)
                    digitValue = Random.Range(0, 10);
            }

            circle.GetComponent<CircleDigit>().Init(digitValue, isCorrect);
        }
    }
}
