using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GameBoard
{

    public int Width;
    public int Height;
    public int Size;
    public int[] Tiles;

}

public class GameBoardRenderer : MonoBehaviour
{
    public GameBoard Board;
    public GameObject BoardObject;
}
