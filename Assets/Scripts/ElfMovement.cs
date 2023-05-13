using UnityEngine;

public class ElfMovement : MonoBehaviour
{
    // Скорость перемещения персонажа
    public float moveSpeed = 5f;

    // Поле назначения
    private Vector3 destination;

    // Флаг движения
    private bool isMoving = false;

    void Update()
    {
        // Обработка кликов мыши
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("jmak");
            // Перевод клика мыши в позицию в мировом пространстве
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // Установка пункта назначения
                destination = hit.point;
                destination.z = transform.position.z;
                Debug.Log(hit);

                // Запуск движения
                isMoving = true;
            }
        }

        // Движение к пункту назначения
        if (isMoving)
        {
            // Вычисление направления движения и перемещение персонажа
            Vector3 direction = (destination - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Проверка на достижение пункта назначения
            if (Vector3.Distance(transform.position, destination) < 0.1f)
            {
                isMoving = false;
            }
        }
    }
}