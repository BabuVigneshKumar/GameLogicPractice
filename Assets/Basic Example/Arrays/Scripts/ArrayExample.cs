using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    int[,] tileMap = new int[3, 3];

    void Start()
    {
        // Set tile values
        tileMap[0, 0] = 1; // grass
        tileMap[0, 1] = 2; // water
        tileMap[0, 2] = 3; // rock

        tileMap[1, 0] = 1;
        tileMap[1, 1] = 2;
        tileMap[1, 2] = 3;

        tileMap[2, 0] = 1;
        tileMap[2, 1] = 2;
        tileMap[2, 2] = 3;

        // Print map
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Debug.Log("Tile[" + row + "," + col + "] = " + tileMap[row, col]);
            }
        }
    }

}
