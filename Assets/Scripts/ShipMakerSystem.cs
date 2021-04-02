using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class GameGrid {
    public bool[] grid;
}

public class ShipMakerSystem : MonoBehaviour
{
    public GameGrid game_grid;

    void Awake()
    {
        game_grid = new GameGrid();
        game_grid.grid = new bool[100];
    }

    public bool CheckPoint(int point)
    {
        int second_point = point - 11;
        for(int i = 0; i < 2; i++)
        {
            for(int z = 0; z < 2; z++)
            {
                if(game_grid.grid.ToList().ElementAtOrDefault(z*2+second_point)) return false;
            }
            second_point = second_point + 20;
        }
        return true;
    }

}
