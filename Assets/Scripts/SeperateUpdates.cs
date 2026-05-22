using UnityEngine;
using TMPro;

public class SeperateUpdates : MonoBehaviour
{
    // Tip: There's a bunch of ways to approach this,
    // but one way that I like to do it takes advantage of a
    // handy "remainder" operator called the modulus operator:
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-

    // Update this script so will display the updated TimeDisplay on
    // only a single TextMeshProUGUI component on a frame.

    // On frame 1, the first TextMeshProUGUI component should display
    // the TimeDisplay

    // On frame 2, the second TextMeshProUGUI component should display
    // the updated TimeDisplay, the first TextMeshProUGUI component
    // should still show the last TimeDisplay value.

    // On frame 3, the third TextMeshProUGUI component should display
    // the updated TimeDisplay, the first TextMeshProUGUI component
    // should still show the first TimeDisplay value, and the second
    // TextMeshProUGUI component should display the last value.

    // etc...through the end of the TextMeshProUGUI components.
    // Once we've reached frame 8 (since we only have 7 TextMeshProUGUI
    // components) it should update the first TextMeshProUGUI component
    // again and continue with this pattern.

    // This should work for any number of TextMeshProUGUI components,
    // or any size of the Texts array.

    [SerializeField] private TextMeshProUGUI[] texts;
    [SerializeField] private float speed = 1;

    private float timeDisplay = 0;
    private int currentIndex = 0;

    private void Awake()
    {
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed > 0)
        {
            timeDisplay = timeDisplay + Time.deltaTime * speed;
            texts[currentIndex].SetText($"{timeDisplay.ToString("N2")}");
            currentIndex++;
            if (currentIndex >= texts.Length)
            {
                currentIndex = 0;
            }
        }
    }
}
