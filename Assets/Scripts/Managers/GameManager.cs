using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private int currentDigitIndex = 0;
    [SerializeField] private int maxDigitsInLevel = 10;

    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private Transform playerStartPoint;

    [SerializeField] private Camera mainCamera;
    [SerializeField] private float cameraYOffset = -3f;
    [SerializeField] private float cameraLerpSpeed = 5f;

    [SerializeField] private TextMeshProUGUI piPrefixText;

    private SpawnManager spawnManager;
    private bool isResolvingHit = false;

    private Vector3 lastBasePosition;
    private float targetCameraY;

    public static int FinalDigitIndex { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        FinalDigitIndex = 0;
    }

    private void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
        if (mainCamera == null)
            mainCamera = Camera.main;

        if (maxDigitsInLevel > PiDigits.MaxDigits)
            maxDigitsInLevel = PiDigits.MaxDigits;

        lastBasePosition = new Vector3(0f, playerStartPoint.position.y, 0f);

        targetCameraY = lastBasePosition.y + cameraYOffset;
        Vector3 camPos = mainCamera.transform.position;
        camPos.y = targetCameraY;
        mainCamera.transform.position = camPos;

        PlacePlayerAt(lastBasePosition);

        spawnManager.SpawnNewSetFromBase(lastBasePosition, currentDigitIndex);

        UpdatePiPrefix();
    }

    private void Update()
    {
        if (mainCamera == null) return;

        Vector3 camPos = mainCamera.transform.position;
        camPos.y = Mathf.Lerp(camPos.y, targetCameraY, cameraLerpSpeed * Time.deltaTime);
        mainCamera.transform.position = camPos;
    }

    private void PlacePlayerAt(Vector3 position)
    {
        if (playerRb == null) return;

        playerRb.linearVelocity = Vector2.zero;
        playerRb.angularVelocity = 0f;
        playerRb.simulated = false;
        playerRb.transform.position = position;
        playerRb.simulated = true;
    }

    private void SetCameraOnBase()
    {
        targetCameraY = lastBasePosition.y + cameraYOffset;
    }

    private void ReleaseLock()
    {
        isResolvingHit = false;
    }

    private void UpdatePiPrefix()
    {
        if (piPrefixText == null) return;
        piPrefixText.text = PiDigits.GetPrefix(currentDigitIndex);
    }

    public void OnCorrectCircleHit(Transform circleTransform)
    {
        if (isResolvingHit) return;
        isResolvingHit = true;

        currentDigitIndex++;
        UpdatePiPrefix();

        if (currentDigitIndex >= maxDigitsInLevel)
        {
            FinalDigitIndex = currentDigitIndex;
            LoadEndScreen();
            return;
        }

        lastBasePosition = new Vector3(0f, circleTransform.position.y, 0f);
        PlacePlayerAt(lastBasePosition);
        Destroy(circleTransform.gameObject);

        SetCameraOnBase();

        spawnManager.SpawnNewSetFromBase(lastBasePosition, currentDigitIndex);

        Invoke(nameof(ReleaseLock), 0.05f);
    }

    public void OnWrongCircleHit()
    {
        if (isResolvingHit) return;
        isResolvingHit = true;

        PlacePlayerAt(lastBasePosition);
        spawnManager.SpawnNewSetFromBase(lastBasePosition, currentDigitIndex);
        SetCameraOnBase();

        Invoke(nameof(ReleaseLock), 0.05f);
    }

    public void OnMissedTarget()
    {
        if (isResolvingHit) return;
        isResolvingHit = true;

        PlacePlayerAt(lastBasePosition);
        SetCameraOnBase();

        Invoke(nameof(ReleaseLock), 0.05f);
    }

    private void LoadEndScreen()
    {
        SceneManager.LoadScene("LevelFinished");
    }
}
