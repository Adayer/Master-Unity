using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject m_ballPrefab;
    [SerializeField] private GameObject m_pinPrefab;

    [SerializeField] private Transform[] m_tPinSpawnPositions;
    [SerializeField] private Transform m_ballSpawnPosition;

    private List<Transform> m_pins;
    private Transform m_ball;

    private void Awake()
    {
        m_pins = new List<Transform>(0);
        m_ball = Instantiate(m_ballPrefab, m_ballSpawnPosition.position, Quaternion.identity).transform;
        Debug.Log(m_tPinSpawnPositions.Length);
        for (int i = 0; i < m_tPinSpawnPositions.Length; ++i)
        {
            GameObject newPin = Instantiate(m_pinPrefab, m_tPinSpawnPositions[i].position, Quaternion.identity);
            m_pins.Add(newPin.transform);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {

    }
}
