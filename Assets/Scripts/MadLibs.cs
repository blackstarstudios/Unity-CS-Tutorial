using UnityEngine;
using TMPro;

public class MadLibs : MonoBehaviour
{
    public TextMeshProUGUI TextMeshPro;

    private string statement = "travesty to my bloodline";
    private string verb = "drink";
    private string noun = "Optimus Prime";
    private string adjective = "obtuse";
    private string pluralNoun = "horses";

    private int number = 19;
    private float percent = 38.69F;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
        TextMeshPro.text = $"This is a {statement}. I did not {verb} ant {noun}. I am not guilty. I am a {adjective} person. The act was performed by {number} wandering {pluralNoun}. I am {percent}% sure of this!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
