using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayMaker : MonoBehaviour
{

    public bool[] grid1;
    public bool[] grid2;
    public Transform currentPlayer;

    // Start is called before the first frame update
    void Awake()
    {
        currentPlayer = transform.GetChild(0);
        grid1 = JsonUtility.FromJson<GameGrid>(PlayerPrefs.GetString("FirstPlayer")).grid;
        grid2 = JsonUtility.FromJson<GameGrid>(PlayerPrefs.GetString("SecondPlayer")).grid;
        PlayerPrefs.DeleteKey("FirstPlayer");
        PlayerPrefs.DeleteKey("SecondPlayer");
    }

    public bool MakeShot(int point)
    {
        // transform.GetSiblingIndex()
        ref bool[] attackedGrid = ref this.grid1;
        if(currentPlayer.transform.GetSiblingIndex() == 1)
        {
            attackedGrid = ref this.grid2;
        }
        if(attackedGrid[point] == true)
        {
            attackedGrid[point] = false;
            if(!attackedGrid.ToList().Contains(true))
            {
                currentPlayer = null;
                onWin(attackedGrid == this.grid1 ? 4 : 5);
            }
            return true;
        }
        return false;
    }

    public void onWin(int count)
    {
        Transform trnsfrm = transform.parent.GetChild(count);
        trnsfrm.gameObject.GetComponent<Text>().text += " победил!";
    }

    public void SwapPlayers()
    {
        if(currentPlayer == transform.GetChild(1))
        {
            currentPlayer = transform.GetChild(0);
        } else
        {
            currentPlayer = transform.GetChild(1);
        }
    }
}
