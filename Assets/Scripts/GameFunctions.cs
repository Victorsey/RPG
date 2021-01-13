using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int RollDices(int modificador)
    {
        return Random.RandomRange(1, 20) + modificador;
    }

    public bool Ataque(Player player)
    {
        return true;
    }
}
