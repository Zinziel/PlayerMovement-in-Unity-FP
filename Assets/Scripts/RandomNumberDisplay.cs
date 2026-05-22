using TMPro;
using UnityEngine;

public class RandomNumberDisplay : MonoBehaviour
{
    // Create a new script that will show a random number
    // between 0 and 1 and display that on a TextMeshProUGUI component,
    // formatted to 2 decimal places.

    [SerializeField] private TextMeshProUGUI text;

    private void Awake()
    {
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(Random.value.ToString("N3"));
    }
}
