using TMPro;
using UnityEngine;

public class TextModifier : MonoBehaviour
{
    private TextMeshProUGUI texto; // Ahora también lo vamos a encontrar automáticamente
    private string nuevoTexto = "Ahora Andrew es super puto"; // Ya no es público, no editable desde el inspector

    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>(); // Buscamos el TextMeshProUGUI en este GameObject

        if (texto != null)
        {
            texto.text = nuevoTexto;
        }
        else
        {
            Debug.LogWarning("No se encontró el componente TextMeshProUGUI en este GameObject.");
        }
    }
}
