using UnityEngine;
using UnityEngine.Tilemaps;
public class CustomTilemapping : MonoBehaviour
{
    [SerializeField] private Tilemap myTileMap;
    [SerializeField] private TileBase groundTail;

    private int[,] TileMap = new int[,]
    {
        {1,1,1,1,1},
        {1,0,0,0,1},
        {1,0,1,0,1},
        {1,0,0,0,1},
        {1,1,1,1,1},
    };

    private void Start()
    {
        GenerateTiles();
    }

    private void GenerateTiles()
    {
        for (int i = 0; i < TileMap.GetLength(0); i++)
        {
           for(int j = 0; j < TileMap.GetLength(1); j++)
            {
                if(TileMap[i,j] == 1)
                {
                   //myTileMap.SetTile(new )
                }
            }
        }
    }
}
