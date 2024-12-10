using UnityEngine;
using UnityEngine.UI;

public class Cronometro_2 : MonoBehaviour
{
    // Variable para referenciar el componente Text
    private Text deltaTimeText;
    private float deltaTimeCounter = 0f;

    private void Awake()
    {
        // Obtenemos el componente
        this.deltaTimeText = GetComponent<Text>();
    }


    private void Update()
    {
        // Actualizar cronómetro basado en deltaTime
        deltaTimeCounter += Time.unscaledDeltaTime;
        deltaTimeText.text = $"{deltaTimeCounter:F2} s";
    }
}
