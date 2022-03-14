using UnityEngine;

namespace TurnBasedBasketball
{
    public class GameBoard : MonoBehaviour
    {

        public Vector3 Origin;
        public Vector2Int GridSize;
        public Vector2 CellSize;
        public Vector3 CellScale;

        public GameObject CellPrefab;
        public Sprite Sprite;
        public Cell[] Cells;

        private void Start()
        {
            Cells = new Cell[GridSize.x * GridSize.y];

            Vector2 tileSize = new Vector2(Sprite.bounds.size.x, Sprite.bounds.size.y);
            tileSize.x *= CellScale.x;
            tileSize.y *= CellScale.z;
            CellSize = tileSize;

            for (int y = 0; y < GridSize.y; y++)
            {
                for (int x = 0; x < GridSize.x; x++)
                {
                    var cellObject = Instantiate(CellPrefab, gameObject.transform);
                    cellObject.transform.position = new Vector3(x * CellSize.x, 0, y * CellSize.y) + Origin;
                    cellObject.transform.localScale = CellScale;
                    var tileObject = cellObject.transform.GetChild(0);
                    var outlineObject = cellObject.transform.GetChild(1);

                    // TODO edit gameboard scale to fine tune?

                    Cell cell = Cells[x + y * GridSize.x] = cellObject.AddComponent<Cell>();
                    cell.Sprite = tileObject.GetComponent<Sprite>();
                    cell.SpriteRenderer = tileObject.GetComponent<SpriteRenderer>();
                    cell.OutlineSprite = outlineObject.GetComponent<Sprite>();
                    cell.OutlineRenderer = outlineObject.GetComponent<SpriteRenderer>();
                    cell.Occupied = false;
                }
            }
        }
    }
}