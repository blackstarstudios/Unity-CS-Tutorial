using UnityEngine;
using TMPro;

public class MyVariables : MonoBehaviour
{
    // Just a scratchpad for trying variables - not in production
    private int health = 100;
    private int myHealth = 100;
    private string messageForTheTextView = "This space for rent";
    // private const int PLAYER_SCORE = 100;
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
