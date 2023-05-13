using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    // Персонаж для спавна
    [SerializeField] private GameObject _characterPrefab;

    // Размер игрового экрана
    [SerializeField] private float _screenWidth = 10f;
    [SerializeField] private float _screenHeight = 10f;

    // Границы спавна персонажа
    private float _minX;
    private float _maxX;
    private float _minY;
    private float _maxY;

    void Awake()
    {
        // Вычисляем границы спавна
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
        // Создаем персонажа и задаем случайную позицию
        Vector3 spawnPosition = new(Random.Range(_minX, _maxX), Random.Range(_minY, _maxY), 0f);
        GameObject character = Instantiate(_characterPrefab, spawnPosition, Quaternion.identity);

        // Добавляем персонажа в список дочерних объектов
        character.transform.parent = transform;
    }
}