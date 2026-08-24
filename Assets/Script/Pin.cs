using UnityEngine;
using TMPro;

public class Pin : MonoBehaviour
{

    [SerializeField] GameObject strike;
    private void OnTriggerEnter(Collider other)
    {
        strike.SetActive(true);
    }
}
