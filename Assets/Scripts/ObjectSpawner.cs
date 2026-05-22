using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private float autoDestroyTime = 10f;
    [SerializeField] private bool spawnInFixedUpdate = false;
    [SerializeField] private AutoDestroyText prefab;

}
