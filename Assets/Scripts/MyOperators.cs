using UnityEngine;
using TMPro;

public class MyOperators : MonoBehaviour
{
    private TextMeshProUGUI TextMeshPro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayMessage()
    {
        int xp = 990;
        xp += 10;
        xp -= 10;
        xp *= 10;
        xp /= 10;

        int str = 10;
        ++str; // adds 1 at all times
        str++; // adds 1 at last time

        int joy = 5 % 2;

        string firstName = "John";
        string lastName = "Jam";
        string fullName = $"{firstName} {lastName}";

        int problem = 3 - (3 * 6) + 2;

        float conversion = (float) 100;
        int largeNumber = 1_000_000;
        byte smallNumber = (byte) largeNumber;

        TextMeshPro.text = $"{xp}";
    }
}
