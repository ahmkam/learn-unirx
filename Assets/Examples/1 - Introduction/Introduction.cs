using UnityEngine;
using UniRx;

public class Introduction : MonoBehaviour
{
    void Start()
    {
        Observable.EveryUpdate()
        .Where(_ => Input.GetMouseButtonDown(0))
        .First()
        .Subscribe(_ => Debug.Log("first left mouse click"));
    }
}
