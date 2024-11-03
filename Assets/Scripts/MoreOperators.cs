using UnityEngine;

public class MoreOperators : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 1;
        int y = 2;
        //bool result = x == y;
        //bool result2 = x != y;

        string playerName = null;
        //bool result = playerName != null;

        int nextLevel = 300;
        int playerXp = 143;
        bool result = (playerXp >= nextLevel);

        Debug.Log(result);
        Debug.Log(!result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
