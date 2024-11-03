using UnityEngine;
using TMPro;

public class TipCalculator : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Calculator()
    {
        int beforeTotal = 30;
        float tipPercent = 10.5F;

        float total = beforeTotal + (beforeTotal * tipPercent);
        textMeshPro.text = $"Before tip : {beforeTotal}, Tip percent: {tipPercent}, Total: {total}";
    }
}
