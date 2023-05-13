using UnityEngine;

public class ElfMovement : MonoBehaviour
{
    // �������� ����������� ���������
    public float moveSpeed = 5f;

    // ���� ����������
    private Vector3 destination;

    // ���� ��������
    private bool isMoving = false;

    void Update()
    {
        // ��������� ������ ����
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("jmak");
            // ������� ����� ���� � ������� � ������� ������������
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log(ray);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // ��������� ������ ����������
                destination = hit.point;
                destination.z = transform.position.z;
                Debug.Log(hit);

                // ������ ��������
                isMoving = true;
            }
        }

        // �������� � ������ ����������
        if (isMoving)
        {
            // ���������� ����������� �������� � ����������� ���������
            Vector3 direction = (destination - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;

            // �������� �� ���������� ������ ����������
            if (Vector3.Distance(transform.position, destination) < 0.1f)
            {
                isMoving = false;
            }
        }
    }
}