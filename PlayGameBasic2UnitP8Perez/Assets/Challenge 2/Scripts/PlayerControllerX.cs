using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _horizontalInput;
    public float _verticalInput;
    public float _speed = 10.0f;
    //public float _xRange = 0.0f;
    public GameObject _projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_projectilePrefab, transform.position, _projectilePrefab.transform.rotation);
        }

        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x);
        viewPos.y = Mathf.Clamp01(viewPos.y);
        transform.position = Camera.main.ViewportToWorldPoint(viewPos);


        _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(_speed * Time.deltaTime * _horizontalInput * Vector3.right);
        _verticalInput = Input.GetAxis("Vertical");
        transform.Translate(_speed * Time.deltaTime * _verticalInput * Vector3.forward);
    }
}