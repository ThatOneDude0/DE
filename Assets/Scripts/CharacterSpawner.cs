using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    // �������� ��� ������
    [SerializeField] private GameObject _characterPrefab;

    // ������ �������� ������
    [SerializeField] private float _screenWidth = 10f;
    [SerializeField] private float _screenHeight = 10f;

    // ������� ������ ���������
    private float _minX;
    private float _maxX;
    private float _minY;
    private float _maxY;

    void Awake()
    {
        // ��������� ������� ������
        _minX = -_screenWidth / 2f;
        _maxX = _screenWidth / 2f;
        _minY = -_screenHeight / 2f;
        _maxY = _screenHeight / 2f;
    }

    void Start()
    {
        CharacterSpawn();
    }

    void CharacterSpawn()
    {
        // ������� ��������� � ������ ��������� �������
        Vector3 spawnPosition = new(Random.Range(_minX, _maxX), Random.Range(_minY, _maxY), 0f);
        GameObject character = Instantiate(_characterPrefab, spawnPosition, Quaternion.identity);

        // ��������� ��������� � ������ �������� ��������
        character.transform.parent = transform;
    }
}