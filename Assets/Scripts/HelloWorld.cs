using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    public string firstName;
    public string lastName;
    private TextMeshProUGUI textMeshPro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Hello {firstName} {lastName}!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
