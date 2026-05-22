using UnityEngine;
using TMPro;

public class CountUp : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] texts;
    [SerializeField] private float speed = 1;
    
    private float timeDisplay = 0;

    private float[] arrayOfFloats;

    private void Start()
    {
        arrayOfFloats = new float[texts.Length];

        arrayOfFloats[0] = 12.25f;
    }


    // Update is called once per frame
    void Update()
    {
        if (speed > 0)
        {
            timeDisplay = timeDisplay + Time.deltaTime * speed;

            // for – führt im body aus, wenn die vorherige Bedingung erfüllt wird
            //for (int i = 0; i < texts.length; i++)
            //{
            //    texts[i].SetText($"{timeDisplay.ToString("N2")}");
            //}

            // while – führt im body unendlich lang aus, solange die vorherige Bedingung erfüllt ist
            //int i = 0;
            //while (i < texts.Length)
            //{
            //    texts[i].SetText($"{timeDisplay.ToString("N2")}");
            //    i++;
            //}

            // do-while – wird konditionell ein oder mehrmals ausgeführt; der Array darf hier nicht leer sein
            //int i = 0;
            //do
            //{
            //    texts[i].SetText($"{timeDisplay.ToString("N2")}");
            //    i++;
            //}
            //while (i < texts.Length );

            // foreach – enumerisiert die Elemente einer Kollektion und wird im body für jedes Element ausgeführt; gut ausführbar, wenn die hierarchische Anordnung der Objekte irrelevant sind
            foreach(TextMeshProUGUI text in texts)
            {
                text.SetText($"{timeDisplay.ToString("N2")}");
            }
        }
    }
}
