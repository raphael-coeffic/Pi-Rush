using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resultText;

    private void Start()
    {
        string prefix = PiDigits.GetPrefix(GameManager.FinalDigitIndex);
        resultText.text = "LEVEL FINISHED!\nYou reached: " + prefix;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

