using DG.Tweening;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] private Transform innerShape, outerShape;
    [SerializeField] private float cicleLength = 2;

    private void Start()
    {
        transform.DOMove(new Vector3(10, 0, 0), cicleLength);
    }
}
