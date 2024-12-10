using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Cronometro : MonoBehaviour
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
        deltaTimeCounter += Time.deltaTime;
        deltaTimeText.text = $"{deltaTimeCounter:F2} s";
    }
}
