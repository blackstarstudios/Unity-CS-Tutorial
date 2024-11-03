using UnityEngine;

public class MyNull : MonoBehaviour
{
    string firstName = "Diege";
    string lastName = null;
    int? meaningOfLife = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int? anotherNumber = null;
        int trueNumber = meaningOfLife ?? anotherNumber ?? 55;
        Debug.Log(trueNumber);
        //Debug.Log($"{firstName} {lastName}");
        //lastName.ToUpper();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
