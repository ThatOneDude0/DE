using UnityEngine;

public class HexGrid : MonoBehaviour
{
    [SerializeField] private int _width = 10;
    [SerializeField] private int _height = 10;
    [SerializeField] private float _hexSize = 1f;
    [SerializeField] private GameObject _hexPrefab;
    [SerializeField] private Vector3 _startPos = new Vector3(0f, 0f, 0f);

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        int numHexes = _width * _height;
        for (int i = 0; i < numHexes; i++)
        {
            float xPos = i % _width * _hexSize * 1.2f;
            float zPos = i / _width * _hexSize * 1.5f;

            if (i % _width % 2 == 1)
            {
                zPos += _hexSize * 0.75f; // Обрабатывать смещение шестиугольников в чередующихся строках
            }

            GameObject hex = Instantiate(_hexPrefab);
            hex.transform.position = new Vector3(_startPos.x + xPos, _startPos.y, _startPos.z + zPos);
            hex.transform.localScale = new Vector3(_hexSize, _hexSize, _hexSize);
            hex.transform.parent = transform;
        }
    }
}