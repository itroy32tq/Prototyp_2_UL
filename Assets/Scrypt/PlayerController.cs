using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float _horizontalInput;
    [SerializeField, Range(1,30)] private float speed = 10f;
    [SerializeField] private float xRange = 10;
    [SerializeField] private GameObject _projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange) transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        if (transform.position.x > xRange) transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        { 
            Instantiate(_projectilePrefab, transform.position, _projectilePrefab.transform.rotation);
        }
    }
}
