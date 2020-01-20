using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BallPitch : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform ballSpawnPoint;

    private GameObject activeBall = null;

    void FixedUpdate()
    {
        Physics.gravity = this.transform.up * -9.8f;
    }

    void SpawnNewBall()
    {
        activeBall = Instantiate(ballPrefab, this.transform);
        activeBall.transform.localPosition = ballSpawnPoint.localPosition;
    }

    void ShootBall(float power)
    {
        if (activeBall != null)
        {
            activeBall.GetComponent<Rigidbody>().AddForce(this.transform.forward * -1f * power, ForceMode.Impulse);
            activeBall = null;
        }
    }

    public void LongPressButtonReleased(float timeHeldDown)
    {
        if (activeBall == null)
        {
            SpawnNewBall();
        }
        else
        {
            ShootBall(timeHeldDown * 0.5f);
        }
    }
}
