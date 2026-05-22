using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))] // An der Klasse gebunden, ähnlich wie SerializeField

public class AutoDestroyText : MonoBehaviour
{
    public float autoDestroyTime = 5f;

    private TextMeshProUGUI text;
    private float spawnTime;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        spawnTime = Time.time;
    }

    private void Update()
    {
        float remainingTime = (spawnTime + autoDestroyTime) - Time.time;

        text.SetText($"{remainingTime:N2}");
        // Ähnlich zu: text.SetText($"{remainingTime.ToString("N2")}");

        if (remainingTime <= 0)
        {
            Destroy(gameObject); // gameObject: The game object this component is attached to. A component is always attached to a game object.
        }
    }
}
